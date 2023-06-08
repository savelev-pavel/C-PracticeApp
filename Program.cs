Company rusLab = new();
rusLab.print_info();


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
            $"Адрес: {this.company_short_name}\n" +
            $"ИНН: {this.company_inn}\n" +
            $"Руководитель: {this.company_director.fullname} " +
            $"{this.company_director.can_sign_docs switch { true => "имеет право подписи", false => "не имеет права подписи" }}");
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
