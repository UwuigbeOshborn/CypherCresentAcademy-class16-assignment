// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var line1 = "Starlight is the light emitted by stars.[1] It typically refers to visible electromagnetic radiation from stars other than the ";
var line2 = "Sun, observable from Earth at night, although a component of starlight is observable from Earth during daytime. ";
var line3 = "Sunlight is the term used for the Sun's starlight observed during daytime.[2] During nighttime, albedo describes solar ";
var line4 = "reflections from other Solar System objects, including moonlight, planet shine, and zodiacal light.[3]";

var text1 = "Starlight is the light emitted by stars.[1] It typically refers to visible electromagnetic radiation from stars other than the " +
    "Sun, observable from Earth at night, although a component of starlight is observable from Earth during daytime. " +
    "Sunlight is the term used for the Sun's starlight observed during daytime.[2] During nighttime, albedo describes solar " +
    "reflections from other Solar System objects, including moonlight, planet shine, and zodiacal light.[3]";

var text2 = "Starlight is the light emitted by stars.[1] It typically refers to visible electromagnetic radiation from stars other than the " +
    "Sun, observable from Earth at night, although a component of starlight is observable from Earth during daytime. " +
    "Sunlight is the term used for the Sun's starlight observed during daytime.[2] During nighttime, albedo describes solar " +
    "reflections from other Solar System objects, including moonlight, planet shine, and zodiacal light.[3]";

var text = string.Concat(line1, line2, line3, line4);

// Assignment1
Console.WriteLine("-----------------------------    Question 1   -----------------------------------");
var extract1 = line2.Substring(15, 15);
var extract2 = line4.Substring(74, 10);
Console.WriteLine(extract1);
Console.WriteLine(extract2);

var merge1 = string.Concat(extract1, extract2);
Console.WriteLine(merge1 + "\n");


// Assignment2
Console.WriteLine("-----------------------------    Question 2   -----------------------------------");
//var newLine1 = line1.Replace("Sun", "Solar Emission", StringComparison.InvariantCultureIgnoreCase);
//var newLine2 = line2.Replace("Sun", "Solar Emission", StringComparison.InvariantCultureIgnoreCase);
//var newLine3 = line3.Replace("Sun", "Solar Emission", StringComparison.InvariantCultureIgnoreCase);
//var newLine4 = line4.Replace("Sun", "Solar Emission", StringComparison.InvariantCultureIgnoreCase);
//Console.WriteLine(newLine1);
//Console.WriteLine(newLine2);
//Console.WriteLine(newLine3);
//Console.WriteLine(newLine4);

var newtext = text.Replace("Sun", "Solar Emission", StringComparison.InvariantCultureIgnoreCase);
Console.WriteLine(newtext + "\n");


// Assignment3
Console.WriteLine("-----------------------------    Question 3   -----------------------------------");
String[] separator = { "." };
Int32 count = 5;

String[] newText1 = text.Split(separator, count, StringSplitOptions.RemoveEmptyEntries);

foreach (String item in newText1)
{
    Console.WriteLine(item + "\n");
}

var mergeText1 = string.Concat(newText1[0], newText1[3]);
Console.WriteLine(mergeText1 + "\n");
mergeText1 = string.Concat(newText1[0], newText1[4]);
Console.WriteLine(mergeText1 + "\n");


// Assignment4
Console.WriteLine("-----------------------------    Question 4   -----------------------------------");
int counter = 0;
string extractor = "";
string extractor1 = "";
string extractor2 = "";
foreach (var item in text1)
{
    if ((item == '[') && (counter == 2))
    {
        extractor2 = text1.Substring(0, text1.IndexOf(item));

    }
    if ((item == '[') && (counter == 1))
    {
        extractor1 = text1.Substring(0, text1.IndexOf(item));
        text1 = text1.Remove(0, text1.IndexOf(']') + 1);
        counter = 2;
    }
    if ((item == '[') && (counter == 0))
    {
        extractor = text1.Substring(0, text1.IndexOf(item));
        text1 = text1.Remove(0, text1.IndexOf(']') + 1);
        counter = 1;
    }
}
var output = string.Concat(extractor, extractor1, extractor2);
Console.WriteLine(output + "\n");

// Assignment5
Console.WriteLine("-----------------------------    Question 5   -----------------------------------");

string vowels = "aeiou";
string consonants = "bcdfghjklmnpqrstvwxyz";
string number = "1234567890";
string specialCharacters = "!@#$%^&*(){}[]_-+/.,<>'";

var allCheckableText = string.Concat(vowels, consonants, number, specialCharacters);
string holder = "";
string extractor3 = "";

foreach (var item in allCheckableText)
{
    if (text2.Contains(item))
    {
        extractor3 = allCheckableText.Substring(allCheckableText.IndexOf(item), 1);
        allCheckableText = allCheckableText.Remove(allCheckableText.IndexOf(item), 1);
        holder = holder.Insert(0, "\"" + extractor3 + "\" ");
    }
}
Console.WriteLine(holder);