// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account.Address;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid and Auth Token at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string addressSid = "AD2a0747eba6abf96b7e3c3ff0b4530f6e";
        TwilioClient.Init(accountSid, authToken);

        var dependentNumbers = DependentPhoneNumberResource.Read(addressSid);

        foreach (var number in dependentNumbers)
        {
            Console.WriteLine(number.FriendlyName);
        }
    }
}
