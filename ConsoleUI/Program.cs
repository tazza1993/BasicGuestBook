using GuestBookLibrary.Models;

var guests = new List<GuestModel>();
GetGuestInformation(guests);
PrintGuestInformation(guests);


static void GetGuestInformation(List<GuestModel>? guests)
{
    var moreGuestsComing = "";

    do
    {
        var guest = new GuestModel()
        {
            FirstName = GetStringInfoFromConsole("What is your first name: "),
            LastName = GetStringInfoFromConsole("What is your second name: "),
            MessageToHost = GetStringInfoFromConsole("What message would you like to tell your host: ")
        };

        moreGuestsComing = GetStringInfoFromConsole("Are more guests coming (yes/no): ");

        guests.Add(guest);

        Console.Clear();
    } while (moreGuestsComing.ToLower() == "yes");
}

static string GetStringInfoFromConsole(string message)
{
    var output = "";
    Console.Write(message);
    output = Console.ReadLine();

    return output;
}

static void PrintGuestInformation(List<GuestModel>? guests)
{
    foreach (var guest in guests)
    {
        Console.WriteLine(guest.GuestInfo);
    }
}