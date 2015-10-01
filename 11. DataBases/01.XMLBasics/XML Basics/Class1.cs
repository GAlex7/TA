using System;

public class Class1
{
	public Class1()
	{
        XmlDocument doc = new XmlDocument();
        doc.Load("../../students.xml");
        Console.WriteLine("Loaded XML document:");
        Console.WriteLine(doc.OuterXml);
        Console.WriteLine();

        XmlNode rootNode = doc.DocumentElement;
        Console.WriteLine("Root node: {0}", rootNode.Name);

    }
}
