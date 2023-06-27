# Media Player Application

The Media Player Application is a robust software that provides essential functionalities for playing audio and video files, managing media libraries, creating playlists, and interacting with the application through a command-line interface.

## Features

The media player application is a robust software that meets the requirements by providing essential functionalities:

1. Playback Functionality:

    - Play audio and video files
    - Control playback with features like play, pause, stop, and seek

2. Media Management:

    - Manage media library by adding, removing, and organizing media files
    - Create and manage playlists.

3. Command-Line Interface:

    - User-friendly command-line interface for easy navigation and interaction
    - Clear instructions and feedback to guide users through operations.

4. Error Handling:

    - Gracefully handle errors and exceptions

## Architecture

The Media Player Application is designed with a solid and clean architecture, following important software engineering principles. Here are the key architectural patterns and principles used:
* Factory Pattern:
    - Implemented the Factory pattern to create different types of media players, such as audio player and video player. This allows for easy extensibility and flexibility in adding new player types.

* Singleton Pattern:
    - Implemented the Singleton pattern to ensure there is only one instance of the media player manager throughout the application. This ensures consistent access to the manager and avoids multiple instances causing conflicts.

## Technologies Used
* C# programming language
* .NET Framework

## Structure

```
📦 Media-Player-Application
├─ .gitignore
├─ MediaPlayer.csproj
├─ README.md
└─ src
   ├─ Controller
   │  └─ CLI
   │     ├─ MediaPlayerCLI.cs
   │     └─ Program.cs
   ├─ Core
   │  ├─ Attributes
   │  │  └─ MediaPlayerTypeAttribute.cs
   │  ├─ Entities
   │  │  ├─ BaseEntity.cs
   │  │  ├─ MediaFile.cs
   │  │  └─ Playlist.cs
   │  ├─ Factory
   │  │  └─ MediaPlayerFactory.cs
   │  ├─ Interfaces
   │  │  ├─ IMediaFileRepository.cs
   │  │  ├─ IPlaybackService.cs
   │  │  ├─ IPlaylistRepository.cs
   │  │  └─ IPlaylistService.cs
   │  └─ Services
   │     ├─ AudioPlaybackService.cs
   │     ├─ PlaylistService.cs
   │     └─ VideoPlaybackService.cs
   ├─ Infrastructure
   │  └─ Data
   │     └─ Repositories
   │        ├─ MediaFileRepository.cs
   │        └─ PlaylistRepository.cs
   └─ Shared
      └─ ErrorHandler.cs
```

## Installation & Usage
1. Clone the repository :
```
   https://github.com/SamAddy/Media-Player-Application.git
```
2. Navigate to the project directory
```
   cd Library-Management-System
```
3. Restore dependencies
```
   dotnet restore
```
4. Run the application 
```
   dotnet run
```