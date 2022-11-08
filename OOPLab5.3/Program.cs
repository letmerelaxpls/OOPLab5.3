using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab5._3
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document was opened");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing document is allowed in Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving document is allowed in Pro version");
        }
     
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Enter edited text");
            string edittext = Console.ReadLine();
            Console.Write("Text that you entered: ");
            Console.WriteLine(edittext);
            Console.WriteLine("Text was edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("The document was saved in .doc format. \nFor saving in new format you need Expert version");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Enter edited text");
            string edittext = Console.ReadLine();
            Console.Write("Text that you entered: ");
            Console.WriteLine(edittext);
            Console.WriteLine("Text was edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document was saved in .docx format");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Microsoft Word");
            Console.WriteLine("Would you like to enter key?");
            Console.WriteLine("1 - Yes\n2 - No");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.Write("Please, enter key: ");
                    int key = int.Parse(Console.ReadLine());
                    if (key == 5125)
                    {
                        Console.WriteLine("You entered Pro version key");
                        ProDocumentWorker proworker = new ProDocumentWorker();
                        proworker.OpenDocument();
                        proworker.EditDocument();
                        proworker.SaveDocument();
                    }
                    else if (key == 6177)
                    {
                        Console.WriteLine("You entered Expert version key");
                        ExpertDocumentWorker expertworker = new ExpertDocumentWorker();
                        expertworker.OpenDocument();
                        expertworker.EditDocument();
                        expertworker.SaveDocument();
                    }
                    break;
                case 2:
                    DocumentWorker worker = new DocumentWorker();
                    worker.OpenDocument();
                    worker.EditDocument();
                    worker.SaveDocument();
                    break;
            }
        }
    }
}
