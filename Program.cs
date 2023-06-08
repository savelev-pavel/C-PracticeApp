Company testComp = new Company{ company_long_name = "ООО \"Русская рулетка\"", company_adress = "Россия, Санкт-Петербург, Невский пр, д.1", company_inn = "12312345",
    company_director = { fullname = "Иванов Петр Сергеевич", can_sign_docs = true } };
testComp.print_info();


class Company
{
    public string company_long_name;
    public string company_short_name;
    public string company_adress;
    public string company_inn;
    public CompanyPerson company_director;

    public Company()
    {
    this.company_long_name = "неизвестно";
    this.company_short_name = "неизвестно";
    this.company_adress = "неизвестно";
    this.company_inn = "неизвестно";
    company_director = new CompanyPerson();
    }

    public void print_info()
    {
        Console.WriteLine($"Организация: {this.company_long_name}\n" +
            $"Адрес: {this.company_adress}\n" +
            $"ИНН: {this.company_inn}\n" +
            $"Руководитель: {this.company_director.fullname} " +
            $"{this.company_director.can_sign_docs switch { true => " - имеет право подписи", false => " - не имеет права подписи" }}");
    }
}

class CompanyPerson
{
    public string position;
    public string fullname;
    public bool can_sign_docs;
    public CompanyPerson()
    {
        position = "неизвестно";
        fullname = "неизвестно";
        can_sign_docs = false;
    }
}
