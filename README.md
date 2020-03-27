![https://github.com/Ledgex/interview-task-senior/actions](https://github.com/Ledgex/interview-task-senior/workflows/build-master/badge.svg)

# Overview

Welcome applicant! This repository contains a very lightweight project (there is no auth, no database). We'd like you to carve out 1-2 hours and perform a few technical tasks.

### Important!

We hope you can spend at most two hours on this project. If you can finish faster — great! If not, limit yourself and don't spend much longer than 2 hours MAX.

## Software Required

You'll need the following software installed on your computer:

- [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/)
- [VSCode](https://code.visualstudio.com/) - We recommend using VSCode for the frontend and navigate to `interview-task-senior\Sample.App\ClientApp`
- [.NET Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2) - (Note: this version is no longer supported by MSFT. We've updated to the latest LTS on our platform)
- [Git](https://git-scm.com/)


## Instructions

- Perform a `git clone` on this repository to your computer.
- Create a branch to perform your work (Ex: `git checkout -b mysubmissionbranch`)
- Open the Visual Studio solution and build/run. This may take a few moments as it also performs an `npm install` for the SPA.
- Perform the tasks below
- Send us a git patch (see the bottom of this doc)

At this point, you should see the following which is a light dashboard showing Market Values pulled in from the API:

![screenshot](https://raw.githubusercontent.com/Ledgex/interview-task-senior/master/readme/screenshot.png "Screenshot of app")

## Tasks

Once you have the project downloaded and installed, we'd like for you to complete the following tasks.

Transactions
1. Create a new page that shows all Transactions in the system in a simple table. The TransactionRepository has fake Transactions already. You'll have to wire this through to an API endpoint.
2. Sort the Transactions by TradeDate DESC.
3. The "Amount" calculation is Units * Price.
4. On the UI, ensure the dollar amounts are properly formatted to show USD currency and the As Of Date is formatted to show MM-DD-YYYY.

Market Values
1. Fix the Market Values on the home dashboard to also format the amount properly
2. Finally, on the Market Values screen, adjust the color of the performance numbers. If the value is > 0%, make it green. If = 0%, leave it black. If < 0% make it red.

## Mockups

New Transaction Page

![screenshot](https://raw.githubusercontent.com/Ledgex/interview-task-senior/master/readme/mockup-transactions.jpg "Transactions Mockup")

## Submitting your work

To submit the changes, send us a git patch from the branch created above.

### Create the patch file

`git format-patch master --stdout > my_submission.patch`

### Send it to us

Zip the patch file and send it to interview.task.submission@ledgex.com with your name somewhere in the body!
