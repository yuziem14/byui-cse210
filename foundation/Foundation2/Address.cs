public class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country) {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsCountryUSA() {
        return _country == "USA";
    }

    public string Display() {
        return $"{_streetAddress}\n{_city} {_state}\n{_country}";
    }
}