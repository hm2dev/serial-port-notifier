; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Serial Port Monitor"
#define MyAppVersion "1.1.2"
#define MyAppPublisher "Helm PCB"
#define MyAppURL "https://www.helmpcb.com"
#define MyAppExeName "Serial Port Monitor.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{1BA93746-19D0-4DF5-AF04-232D132752D6}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename={#MyAppName} v{#MyAppVersion}
Compression=lzma
SolidCompression=yes
CloseApplications=force

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Files]
Source: "bin\x86\Release\Serial Port Monitor.exe"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{userstartup}\{#MyAppName}"; Filename: "{app}\Serial Port Monitor.exe"; IconFilename: "{app}\Serial Port Monitor.exe"; IconIndex: 0

[Run]
Filename: "{app}\Serial Port Monitor.exe"; Flags: nowait postinstall
