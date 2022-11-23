# Bingo Caller

A web application to help Bingo Callers and participants keep track of numbers!

Deployed Version : https://stereobingo.azurewebsites.net/

## Requirements:

- This app can be run via a [Dev Container](https://code.visualstudio.com/docs/devcontainers/containers)
- If you want to install dependencies locally, then you will need [Dotnet 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

## Running the App

- Create a dev certificate `dotnet dev-certs https`
- Start the local server `dotnet watch run --project BingoCaller.csproj`

  Note: Hot reload will be enabled and update the page automatically when a client side change is applied in vscode.

## Using the Site

There are two main modes for BingoCaller, participant and caller. The Caller is the person running the game and who announces numbers.

- Participant: 
  The home screen is the participant screen. This page listens for events from the server and updates the board accordingly.
- Caller: 
  This screen requires a login (set in appsettings or appsettings.Develeopment.json), and allows an announcer to click a number. This emits a message that is sent to all clients. Each board then renders a selection. 

  Callers can also click a number a second time to unselect it.

  The call screen also includes a New Game button, this sends a NewGame event which instructs client boards to clear all selected numbers.
