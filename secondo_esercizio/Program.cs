// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Inserisci i dati della persona:");

Person person = new Person();

Console.Write("Nome: ");
person.FirstName = Console.ReadLine();
Console.Write("Cognome: ");
person.SecondName = Console.ReadLine();
Console.Write("Sesso: ");
person.Gender = Console.ReadLine();
Console.Write("Città di nascita: ");
person.BirthCity = Console.ReadLine();
Console.Write("Codice città di nascita: ");
person.BirthCityCode = Console.ReadLine();
Console.Write("Data di nascita (yyyy-MM-dd): ");
if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
{
    person.BirthDate = birthDate;

    Console.WriteLine($"Età: {person.Age()}");
    Console.WriteLine($"Codice fiscale: {person.Fiscalcode()}");
}
else
{
    Console.WriteLine("Data di nascita non valida.");
}
class Person
{
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Gender { get; set; }
    public string BirthCity { get; set; }
    public string BirthCityCode { get; set; }
    public DateTime BirthDate { get; set; }

    public enum GenderType
    {
        Male,
        Female,
        NotSpecified
    }

    public int Age()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - BirthDate.Year;
        if (BirthDate > currentDate.AddYears(-age))
        {
            age--;
        }
        return age;
    }

   /*
    public string FiscalCode()
    {
        string result, gender;

        //create an istance of CodiceFiscale class
        CodiceFiscaleUtility.CodiceFiscale FiscalCode;

        //adapt the Gender property to the string type required by CodiceFiscale class

        if (this.Gender == GenderType.NotSpecified)
        {
            //if gender is missing, can't calculate fiscal code
            result = "";
        }
        else
        {
            if (this.Gender == GenderType.Male)
            {
                gender = "M";
            }
            else
            {
                gender = "F";
            }

            FiscalCode = new CodiceFiscaleUtility.CodiceFiscale(this.LastName, this.FirstName, gender, this.BirthDate, this.BirthCity, this.BirthProvince);

            //use CodiceFiscale class to generate the fiscal code
            result = FiscalCode.Codice;
        }

        return result;
    }
   */
}




