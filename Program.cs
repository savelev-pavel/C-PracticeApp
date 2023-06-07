Company rusLab = new Company();
rusLab.print_info();


class Company
{
    public string company_long_name = "неизвестно";
    public string company_short_name = "неизвестно";
    public string company_adress = "неизвестно";
    public string company_inn = "неизвестно";
    public CompanyPerson company_director;
    public CompanyPerson company_accountant;
    public void print_info()
    {
        Console.WriteLine($"Организация {this.company_long_name}\n" +
            $"Адрес: {this.company_short_name}\n" +
            $"ИНН: {this.company_inn}\n" +
            $"Руководитель: {this.company_director.fullname} " +
            $"{this.company_director.can_sign_docs switch { true => "имеет право подписи", false => "не имеет права подписи" }}");
    }
}

class CompanyPerson
{
    public string position = "неизвестно";
    public string fullname = "неизвестно";
    public bool can_sign_docs = false;
}
