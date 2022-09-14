using static System.Console;
class LetterDemo
{
   static void Main()
   {
     Letter letter = new Letter();
     letter.Name = "Electric Company";
     letter.Date = "9/14/2022";
     WriteLine(letter.ToString());


   }
}

class Letter 
{
  public string Name { get; set; }
  public string Date { get; set; }

  public override string ToString()
  {
    return(GetType() + ": " + Name + " " + Date);
  }
}

class CertifiedLetters : Letter
{

}

