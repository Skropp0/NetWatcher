using Microsoft.Toolkit.Uwp.Notifications;


Console.WriteLine("Hello, World!");

new ToastContentBuilder()
    .AddArgument("action", "viewConversation")
    .AddArgument("conversationId", 9813)
    .AddText("Hello Will!")
    .AddText("This is Clem Fandango, can you hear me?")
    .AddProgressBar("progress", 0.42, valueStringOverride:"valueString", status:"status")
    .SetToastDuration(ToastDuration.Long)
    .AddButton("A button", ToastActivationType.Foreground, "args")
    .Show();

Console.ReadKey();
//Task.Delay(10000);

Console.WriteLine("...Bye!...");
