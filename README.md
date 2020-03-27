# Overview

Welcome applicant! This repository contains a very lightweight project that we'd like you to perform a few technical tasks on. Once the pre-requisite software is installed, we only expect you to spend 1-2 hours on this!

Please install the required software, check out the instructions, and tasks. Instructions on how to submit are at the bottom.

## Software Required

You'll need the following software installed on your computer:

- [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/)
- [VSCode](https://code.visualstudio.com/) - We recommend using VSCode for the frontend.
- [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- [Git](https://git-scm.com/)


## Instructions

- Perform a `git clone` on this repository to your computer.
- Create a branch to perform your work (Ex: `git checkout -b mysubmission)
- Open the Visual Studio solution and build/run. This may take a few moments as it also performs an `npm install` for the SPA.
- Perform the tasks below
- Send us a git patch (see the bottom of this doc)

At this point, you should see the following:

![screenshot](https://github.com/Ledgex/interview-senior-engineer/blob/master/readme/screenshot.png "Screenshot of app")

## Tasks

Once you have the project downloaded and installed, we'd like for you to complete the following tasks. We've included a few small bonus tasks/fixes as well.

Transactions
1. Create a new page that shows all Transactions in the system in a simple table. The TransactionRepository has fake Transactions already. You'll have to wire this through to an API endpoint. 
2. Sort the Transactions by TradeDate DESC.
3. The "Amount" calculation is Units * Price.
4. On the UI, ensure the amounts are properly formatted show USD currency and the As Of Date is formatted to show MM-DD-YYYY.

Market Values
1. Fix the Market Values on the home dashboard to also format the amount properly
2. Finally, on the Market Values screen, adjust the color of the performance numbers. If the value is > 0%, make it green. If = 0%, leave it black. If < 0% make it red.

## Mockups

New Transaction Page

![screenshot](https://github.com/Ledgex/interview-senior-engineer/blob/master/readme/mockup-transactions.jpg "Transactions Mockup")

## Submitting your work

To submit the project, send us a git patch from the branch created above.

### Create the patch file
`git format-patch master --stdout > my_submission.patch`

### Send it to us

Zip the patch file and send it to interview.task.submission@ledgex.com with your name somewhere in the body!