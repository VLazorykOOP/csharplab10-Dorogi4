using System;

// Власні класи винятків
public class ArrayTypeMismatchException : Exception
{
    public ArrayTypeMismatchException(string message) : base(message) { }
}

public class DivideByZeroException : Exception
{
    public DivideByZeroException(string message) : base(message) { }
}

public class IndexOutOfRangeException : Exception
{
    public IndexOutOfRangeException(string message) : base(message) { }
}

public class InvalidCastException : Exception
{
    public InvalidCastException(string message) : base(message) { }
}

public class OutOfMemoryException : Exception
{
    public OutOfMemoryException(string message) : base(message) { }
}

public class OverflowException : Exception
{
    public OverflowException(string message) : base(message) { }
}

public class StackOverflowException : Exception
{
    public StackOverflowException(string message) : base(message) { }
}

// Базовий клас Document
public abstract class Document
{
    public string Number { get; set; }
    public DateTime Date { get; set; }

    // Віртуальний метод для виведення інформації
    public virtual void PrintInfo()
    {
        try
        {
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine($"Date: {Date}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in PrintInfo: {ex.Message}");
        }
    }
}

// Похідний клас Receipt
public class Receipt : Document
{
    public decimal Amount { get; set; }

    // Перевизначення методу PrintInfo для Receipt
    public override void PrintInfo()
    {
        try
        {
            base.PrintInfo();
            Console.WriteLine($"Amount: {Amount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in PrintInfo of Receipt: {ex.Message}");
        }
    }
}

// Похідний клас Invoice
public class Invoice : Document
{
    public string CustomerName { get; set; }

    // Перевизначення методу PrintInfo для Invoice
    public override void PrintInfo()
    {
        try
        {
            base.PrintInfo();
            Console.WriteLine($"Customer Name: {CustomerName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in PrintInfo of Invoice: {ex.Message}");
        }
    }
}

// Похідний клас Bill
public class Bill : Document
{
    public string Recipient { get; set; }

    // Перевизначення методу PrintInfo для Bill
    public override void PrintInfo()
    {
        try
        {
            base.PrintInfo();
            Console.WriteLine($"Recipient: {Recipient}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in PrintInfo of Bill: {ex.Message}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Створення об'єктів кожного класу
            Document doc1 = new Receipt { Number = "R001", Date = DateTime.Now, Amount = 100.50m };
            Document doc2 = new Invoice { Number = "INV001", Date = DateTime.Now, CustomerName = "John Doe" };
            Document doc3 = new Bill { Number = "B001", Date = DateTime.Now, Recipient = "Company XYZ" };

            // Тестування виведення інформації про кожен документ
            PrintDocumentInfo(doc1);
            PrintDocumentInfo(doc2);
            PrintDocumentInfo(doc3);
        }
        catch (ArrayTypeMismatchException ex)
        {
            Console.WriteLine($"ArrayTypeMismatchException caught: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"DivideByZeroException caught: {ex.Message}");
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"IndexOutOfRangeException caught: {ex.Message}");
        }
        catch (InvalidCastException ex)
        {
            Console.WriteLine($"InvalidCastException caught: {ex.Message}");
        }
        catch (OutOfMemoryException ex)
        {
            Console.WriteLine($"OutOfMemoryException caught: {ex.Message}");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"OverflowException caught: {ex.Message}");
        }
        catch (StackOverflowException ex)
        {
            Console.WriteLine($"StackOverflowException caught: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"General Exception caught: {ex.Message}");
        }
    }

    // Метод для виведення інформації про документ
    static void PrintDocumentInfo(Document doc)
    {
        try
        {
            Console.WriteLine("\nDocument Information:");
            doc.PrintInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in PrintDocumentInfo: {ex.Message}");
        }
    }
}
