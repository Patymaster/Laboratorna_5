using System;

namespace ConsoleApp1
{
    class Program
    {
        private const string PRO = "1";
        private const string EXP = "2";

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть ключ: ");
            var license = Console.ReadLine();
            DocumentWorker worker;
            switch (license)
            {
                case PRO: worker = new ProDocumentWorker(); break;
                case EXP: worker = new ExpertDocumentWorker(); break;
                default: worker = new DocumentWorker(); break;
            }
            while (true)
            {
                Console.WriteLine("Введiть команду: (o/e/s/q): ");
                switch (Console.ReadLine())
                {
                    case "o": worker.OpenDocument(); break;
                    case "e": worker.EditDocument(); break;
                    case "s": worker.SaveDocument(); break;
                    case "q": return;
                }
            }
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ вiдкрито");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Редактування документу доступно в версiї Про");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Збереження документу доступно в версiї Про");
        }
    }

    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ вiдредактовано!");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено в старому форматi, збереження в iнших форматах доступно в версiї Експерт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ збережено в новому форматi");
        }
    }
}