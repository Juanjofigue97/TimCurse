

using HelloUser;

UserInteraction.AppStartMessage();

string userName = UserInteraction.AskUserName();

UserInteraction.HelloUser(userName);

UserInteraction.SayGoodBye();

Console.ReadLine();
