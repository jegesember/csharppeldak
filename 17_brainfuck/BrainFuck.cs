using System;
using System.IO;
using System.Windows.Forms;

namespace _17_brainfuck
{
    internal class BrainFuck
    {
        /// <summary>
        /// Adat memória
        /// </summary>
        private byte[] _memory;

        /// <summary>
        /// Brainfuck kód
        /// </summary>
        private string _code;

        /// <summary>
        /// Memória Limit
        /// </summary>
        private int _maxmemory;

        /// <summary>
        /// Memória mutató
        /// </summary>
        private int _MemPtr;

        /// <summary>
        /// Aktuális utasítás mutató
        /// </summary>
        private int _IPtr;

        public BrainFuck(int maxmemory = 4096)
        {
            _maxmemory = maxmemory;
            _memory = new byte[_maxmemory];
            _MemPtr = 0;
        }

        /// <summary>
        /// Hibaüzenet megjelenítése
        /// </summary>
        /// <param name="hiba">Üzenet tárgya</param>
        private void Error(string hiba)
        {
            MessageBox.Show(hiba, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Kód betöltése a vágólapról
        /// </summary>
        public void LoadClipboard()
        {
            if (Clipboard.ContainsText()) _code = Clipboard.GetText();
            else Error("A vágólapon nem szöveges infromáció található.");
        }

        /// <summary>
        /// Kód betöltése egy TXT fájlból
        /// </summary>
        public void LoadFromFile()
        {
            try
            {
                //megnyitás ablak létrehozása
                OpenFileDialog ofd = new OpenFileDialog();
                //kiterjesztések beállítása
                ofd.Filter = "Szöveges fájlok | *.txt";
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    if (fi.Length > _maxmemory)
                    {
                        Error("A betölteni kívánt fájl nagyobb, mint az értelmező memória korlátja!");
                        return;
                    }
                    //using direktíva az IDisposable interfész miatt
                    using (TextReader tx = File.OpenText(ofd.FileName))
                    {
                        //a fájl egész tartalmát beolvassuk a memóriába
                        _code = tx.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                Error("Hiba történt a fájl mengyitása,beolvasása közben:\r\n" + ex.Message);
            }
        }

        /// <summary>
        /// Értelmező alapállapotba állítása
        /// </summary>
        public void Reset()
        {
            _code = null;
            _memory = null;
            //szemétgyüjtő kényszerített hívása. Első híváskor általában a destruktorokat hívja meg
            GC.Collect();
            //megvárjuk a folyamatban lévő destruktor futást
            GC.WaitForPendingFinalizers();
            //Szemétgyüjtő meghívása megint, tényleges memória felszabadítás
            GC.Collect();
            _memory = new byte[_maxmemory];
            _MemPtr = 0;
            _IPtr = 0;
        }

        /// <summary>
        /// Ciklus eleje
        /// </summary>
        private void LoopStart()
        {
            int bal = 1;
            if (_memory[_MemPtr] == '\0')
            {
                do
                {
                    _IPtr++;
                    if (_code[_IPtr] == '[') bal++;
                    else if (_code[_IPtr] == ']') bal--;
                }
                while (bal != 0);
            }
        }

        /// <summary>
        /// Ciklus vége
        /// </summary>
        private void LoopEnd()
        {
            int bal = 0;
            do
            {
                if (_code[_IPtr] == '[') bal++;
                else if (_code[_IPtr] == ']') bal--;
                _IPtr--;
            }
            while (bal != 0);
        }

        /// <summary>
        /// Brainfuck program futtatása
        /// </summary>
        public void Run()
        {
            while (_IPtr < _code.Length)
            {
                switch (_code[_IPtr])
                {
                    case '>':
                        ++_MemPtr;
                        break;
                    case '<':
                        --_MemPtr;
                        break;
                    case '+':
                        _memory[_MemPtr]++;
                        break;
                    case '-':
                        _memory[_MemPtr]--;
                        break;
                    case '.':
                        Console.Write((char)_memory[_MemPtr]);
                        break;
                    case ',':
                        var key = Console.ReadKey();
                        _memory[_MemPtr] = (byte)key.KeyChar;
                        break;
                    case '[':
                        LoopStart();
                        break;
                    case ']':
                        LoopEnd();
                        break;
                }
                ++_IPtr;
                if (_MemPtr > _maxmemory) throw new Exception("A memória pointer túlment a maximális memória határon");
                if (_MemPtr < 0) throw new Exception("A memória pointer negatív memóriába mutatott");
            }
        }
    }
}
