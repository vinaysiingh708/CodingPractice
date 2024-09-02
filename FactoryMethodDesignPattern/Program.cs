using System;
namespace FactoryMethodDesignPattern
{

    //According to the Gang of Four, the Factory Method Design Pattern
    //Defines an interface for creating an object but lets the subclasses decide which class to instantiate.
    //The Factory method lets a class defer instantiation to subclasses.

    // Product Interface: IDocument
    public interface IDocument
    {
        void Open();
        void Save();
    }

    // Concrete Products: WordDocument and PdfDocument
    public class WordDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening Word document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving Word document...");
        }
    }

    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF document...");
        }

        public void Save()
        {
            Console.WriteLine("Saving PDF document...");
        }
    }

    // Creator: DocumentCreator
    public abstract class DocumentCreator
    {
        public abstract IDocument CreateDocument();
    }

    // Concrete Creators: WordDocumentCreator and PdfDocumentCreator
    public class WordDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new WordDocument();
        }
    }

    public class PdfDocumentCreator : DocumentCreator
    {
        public override IDocument CreateDocument()
        {
            return new PdfDocument();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Word document using the factory method
            DocumentCreator wordCreator = new WordDocumentCreator();
            IDocument wordDoc = wordCreator.CreateDocument();
            wordDoc.Open();
            wordDoc.Save();

            // Create a PDF document using the factory method
            DocumentCreator pdfCreator = new PdfDocumentCreator();
            IDocument pdfDoc = pdfCreator.CreateDocument();
            pdfDoc.Open();
            pdfDoc.Save();
        }
    }

}