***********Product**********
using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    public string _productName;
    public string _serialNumber;
    public DateTime _purchaseDate;
    public double _cost;

    
    public Product(string _productName, string _serialNumber, DateTime _purchaseDate, double _cost)
    {
        this._productName = _productName;
        this._serialNumber = _serialNumber;
        this._purchaseDate = _purchaseDate;
        this._cost = _cost;
    }

   
    public string ProductName
    {
        set { this._productName = value; }
        get { return this._productName; }
    }
    public string SerialNumber
    {
        set { this._serialNumber = value; }
        get { return this._serialNumber; }
    }
    public DateTime PurchaseDate
    {
        set { this._purchaseDate = value; }
        get { return this._purchaseDate; }
    }
    public double Cost
    {
        set { this._cost = value; }
        get { return this._cost; }
    }
    public override string ToString()
    {
        return String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", ProductName, SerialNumber, String.Format("{0:d}", PurchaseDate), Cost);
    }
}


********Program**********



using System;
using System.Collections;
using System.Globalization;
using System.IO;


public class Program  
{
    public static void Main(string[] args) 
    {

        
        StreamReader reader = new StreamReader("input.csv");
        string data = "";
        Product p = null;
        ArrayList arlobj = new ArrayList();
        while ((data = reader.ReadLine()) != null)
        {
            string[] info = data.Split(',');
            string productName = info[0].Trim();
            string serialNumber = info[1].Trim();
            DateTime purchaseDate = DateTime.ParseExact(info[2].Trim(), "dd-MM-yyyy", null);
            double cost = Double.Parse(info[3].Trim());
            p = new Product(productName, serialNumber, purchaseDate, cost);
            arlobj.Add(p);

        }
        Console.WriteLine("{0}", String.Format("{0,-15}{1,-15}{2,-15}{3,-15}", "Product Name", "Serial Number", "Purchase Date", "Cost"));
        foreach (var obj in arlobj)
        {
            Product prd = (Product)obj;
            Console.WriteLine("{0}", prd.ToString());
        }
    }
}
