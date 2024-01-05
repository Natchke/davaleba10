using System;

namespace meate_davaleba
{
    class Program
    {
        static void Main()
        {
             FileWorker textFileWorker = new TextFileWorker(128);
            textFileWorker.Write();
            textFileWorker.Read();
            textFileWorker.Delete();
            textFileWorker.Edit();

             }
           
        }
    public abstract class FileWorker
    {
        protected int MaxFileSize { get; }

        public abstract string FileExtension { get; }

        protected FileWorker(int maxFileSize)
        {
            MaxFileSize = maxFileSize;
        }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();
    }
    public class TextFileWorker : FileWorker
    {
        public TextFileWorker(int maxFileSize) : base(maxFileSize) { }

        public override string FileExtension
        {
            get { return ".txt"; }
        }

        public override void Read()
        {
            Console.WriteLine("I Can read from " + FileExtension + " file with max storage " + MaxFileSize);
        }

        public override void Write()
        {
            Console.WriteLine("I Can write to " + FileExtension + " file with max storage " + MaxFileSize);
        }

        public override void Edit()
        {
            Console.WriteLine("I Can edit " + FileExtension + " file with max storage " + MaxFileSize);
        }

        public override void Delete()
        {
            Console.WriteLine("I Can delete from " + FileExtension + " file with max storage " + MaxFileSize);


        }
    }

}