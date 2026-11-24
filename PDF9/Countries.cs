namespace PDF9
{
    internal enum Countries
    {
        Russia, France, Kazakhstan, China
    }

    internal class EnumName
    {
        public static string CountryName(Countries country)
        {
            return (country) switch
            {
                Countries.Russia => "Россия",
                Countries.France => "Франция",
                Countries.Kazakhstan => "Казахстан",
                Countries.China => "Китай",
                _ => throw new ArgumentException("Неизвестная страна!")
            };
        }
    }
}
