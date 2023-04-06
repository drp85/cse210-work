using System;

class Address
{
    public string Street;
    public string City;
    public string State;
    public string Zip;

    public Address(string street, string city, string state, string zip)
    {
        Street = street;
        City = city;
        State = state;
        Zip = zip;
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {State} {Zip}";
    }
}