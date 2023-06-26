


using GuestBookFamily;

GuestLogic.AuthorMessage();

bool continueApp = true;
//var guestList = GuestListFunction.GetGuestList();
List<Family> guestList = new();

while (continueApp)
{
    GuestLogic.WelcomeMessage();
    var option = GuestLogic.MenuOption();

    switch (option)
    {
        case 1:
            Console.Clear();
            var newFamily = GuestLogic.GetGuests();
            guestList = GuestLogic.AddGuest(guestList, newFamily);
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            GuestLogic.PrintGuestList(guestList);
            break;
        case 3:
            continueApp = false;
            break;
    }
}