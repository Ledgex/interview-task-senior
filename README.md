# Overview

Welcome applicant! This repository contains a very lightweight project that we'd like you to perform a few technical tasks on. Once the pre-requisite software is installed, we only expect you to spend a few hours on this!

Please install the required software, check out the instructions, and tasks. Instructions on how to submit are at the bottom.

## Software Required

You'll need the following software installed on your computer:

- [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/)
- [VSCode](https://code.visualstudio.com/) - We recommend using VSCode for the frontend.
- [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- [Git](https://git-scm.com/)


## Instructions

- Install required software needed to work on the sample project (see "Software Required" above).
- Perform a `git clone` on this repository to your computer.
- Open the Visual Studio solution and build/run. This may take a few moments as it also performs an `npm install` for the SPA.

At this point, you should see the following:

![screenshot](https://github.com/Ledgex/interview-senior-engineer/blob/master/readme/screenshot.png "Screenshot of app")

## Tasks

Once you have the project downloaded and installed, we'd like for you to complete the following tasks. We've included a few small bonus tasks/fixes as well.

1. Create a new page that shows all Transactions in the system. The TransactionRepository has fake Transactions already that you can pull in through the API.
2. Sort the Transactions by TradeDate DESC.
3. The "Amount" calculation is Units * Price.
4. On the UI, ensure the amounts are properly formatted show USD currency and the As Of Date is formatted to show MM-DD-YYYY.
5. Fix the Market Values screen to also format the amount properly
6. Finally, on the Market Values screen, adjust the color of the performance numbers. If the value is > 0%, make it green. If = 0%, leave it black. If < 0% make it red.

## Mockups

New Transaction Page

![screenshot](https://github.com/Ledgex/interview-senior-engineer/blob/master/readme/mockup-transactions.jpg "Transactions Mockup")

## Submitting your work

To submit the project, send us a git patch. [Instructions TBD]