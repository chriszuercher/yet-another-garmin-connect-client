﻿using Spectre.Console.Cli;
using YAGCC.Commands.UploadBloodPressure;
using YAGCC.Commands.UploadBodyComposition;

var app = new CommandApp();

app.Configure(config =>
{
    config.SetApplicationName("YAGCC");
    config.AddCommand<UploadBodyCompositionCommand>("uploadbodycomposition")
    .WithExample("uploadbodycomposition", "--weight", "80", "--bone-mass", "14","--fat", "13", "--hydration", "58", "--muscle-mass", "42", "--email", "john.doe@mail.com", "-p", "<PASSWORD>");
    config.AddCommand<UploadBloodPressureCommand>("uploadbloodpressure")
   .WithExample("uploadbloodpressure", "--heartrate", "60", "--systolic", "110", "--diastolic", "55",  "--email", "john.doe@mail.com", "-p", "<PASSWORD>");
    config.PropagateExceptions();
#if DEBUG

    config.ValidateExamples();
#endif
});

return app.Run(args);