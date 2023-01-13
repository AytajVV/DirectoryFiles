// See https://aka.ms/new-console-template for more information
#region Directory
//Directory.CreateDirectory(@"C:\Users\Orbit Computers\Desktop\Test");
//if (!Directory.Exists(@"C:\Users\Orbit Computers\Desktop\Test"))
//{
//    Directory.CreateDirectory(@"C:\Users\Orbit Computers\Desktop\Test");
//}

//if (Directory.Exists(@"C:\Users\Orbit Computers\Desktop\Test"))
//{
//    Directory.Delete(@"C:\Users\Orbit Computers\Desktop\Test");
//}

//string[] array = Directory.GetFiles(@"C:\Users\Orbit Computers\Desktop\Test");
//string[] array1 = Directory.GetDirectories(@"C:\Users\Orbit Computers\Desktop\Test");
//foreach (var item in array)
//{
//    Console.WriteLine(item);
//}
//foreach (var item in array1)
//{
//    Console.WriteLine(item);
//}
#endregion
#region File
//if (File.Exists(@"C:\Users\Orbit Computers\Desktop\Test\HelloGuys.txt"))
//{
//    File.Delete(@"C:\Users\Orbit Computers\Desktop\Test\HelloGuys.txt");
//}

//File.CreateText(@"C:\Users\Orbit Computers\Desktop\Test\HelloGuysHey.txt");


//File.Create(@"C:\Users\Orbit Computers\Desktop\Test\HelloGuys.txt");
#endregion


//StreamWriter streamWriter = new StreamWriter(@"C:\Users\Orbit Computers\Desktop\Test\HelloGuys.txt");
//streamWriter.WriteLine("my name");
//streamWriter.Close();

# region StreamReader
using DirectoryFile.Product;

string path = @"C:\Users\Orbit Computers\Desktop\Test\HelloGuys.txt";


//StreamWriter streamWriter = new StreamWriter(path);
//streamWriter.Write("my name is ");
//streamWriter.Close();

//using(StreamWriter stream = new StreamWriter(path))
//{
//    stream.WriteLine("Aytac");
//}
//string result;
//using (StreamReader stream = new StreamReader(path))
//{
//    result = stream.ReadToEnd();
//}
//Console.WriteLine(result);

#endregion

Product product = new Product { Id = 1, Name = "Book", Price = 10 };
Product product1 = new Product { Id = 2, Name = "Computer", Price = 1000 };

ProductItem ProductItem = new ProductItem { Id = 1, Product = product, Count = 2, TotalPrice = 20 };
ProductItem ProductItem1 = new ProductItem { Id = 2, Product = product1, Count = 3, TotalPrice = 3000 };

List<ProductItem> productItems = new List<ProductItem>();
productItems.Add(ProductItem1);
productItems.Add(ProductItem);
ProductItems ProductItems = new ProductItems { Id = 1, productItems=productItems };