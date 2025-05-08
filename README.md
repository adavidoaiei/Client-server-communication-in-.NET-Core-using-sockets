# Client Server Communication in .NET Core using sockets

<img src="https://i.imgur.com/OLAkD0Y.png">

## Overview
This project demonstrates TCP/IP socket-based communication between a client and server using .NET Core. The application consists of two main components: a server that listens for incoming connections and a client that can send messages to the server.

## Features
- TCP/IP socket-based communication
- Asynchronous client-server connection
- Console-based interface
- Real-time message transmission
- Support for multiple client connections
- Simple text-based protocol

## Prerequisites
- .NET Core SDK (Project targets .NET Core 2.0)
- Basic understanding of TCP/IP communication

## Project Structure
- `ClientServer.sln` - Main solution file
- `Client/` - Client application
  - `Program.cs` - Client implementation
- `ClientServer/` - Server application
  - `Server.cs` - Server implementation

## How It Works
1. The server starts listening on IP address 127.0.0.1 (localhost) and port 443
2. Client can connect to the server using the same IP and port
3. Once connected, the client can send text messages to the server
4. The server displays received messages in the console
5. Client can type 'quit' to terminate the connection

## Running the Application

### Starting the Server
1. Navigate to the ClientServer directory
2. Run the server application using:
```bash
dotnet run
```
The server will start listening for incoming connections on port 443.

### Starting the Client
1. Navigate to the Client directory
2. Run the client application using:
```bash
dotnet run
```
3. Follow the console prompts to send messages to the server

## Features in Detail
### Server
- Listens for incoming TCP connections
- Handles multiple client connections
- Displays received messages in real-time
- Maintains persistent connections until client disconnects

### Client
- Connects to server using TCP
- Allows user to input messages via console
- Sends messages to server in real-time
- Can terminate connection using 'quit' command

## Technical Implementation
- Uses `TcpListener` for server-side socket programming
- Uses `TcpClient` for client-side connections
- Implements asynchronous communication using `async/await`
- Uses ASCII encoding for message transmission
- Includes error handling and connection management

## Notes
- The server runs on localhost (127.0.0.1) by default
- Default port is 443
- Maximum message size is 1024 bytes
- Connection remains active until explicitly terminated

## License
This project is open source and available under the MIT license.
