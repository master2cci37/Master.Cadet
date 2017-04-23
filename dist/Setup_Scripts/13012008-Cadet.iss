; ==========================================================================
; Nom de fichier : Cadet.iss
; Info Version  : script d installation d'Cadet.
;                 copie le programme, créé une icone sur le bureau et 
;                 dans menu demarrer
; Copyright : 01/2008 Master 2 CCI /  UFRT / UE1 Professeur :  M.  DI SCALA
; Auteur(s) : Mehdi ALLAS, JF. PACORY, Mahmoud BOUKERROUI
; Etat : 
;--------------------------------------------------------------------------
; Révision(s) :
; 14012008 MB : mise en place des differents parametres
;========================================================================== 
[Setup]
AppName=Cadet
AppVerName=Cadet Version 1.0
AppPublisher=My Company, Inc.
AppPublisherURL=http://www.example.com/
AppCopyright=Copyright (C) 1997-2005 My Company, Inc.
OutputManifestFile=Cadet.log
DefaultDirName={pf}\Cadet
DefaultGroupName=Cadet
UninstallDisplayIcon={app}\Cadet.exe
Compression=lzma
SolidCompression=yes
; chemin des fichiers sources
SourceDir=C:\Users\topmaster\Desktop\Cadet\
; chemin de creation de setup.exe :
OutputDir=C:\Users\topmaster\Desktop
; mise à jour des date heure des fichiers  (time = version)
TouchDate=2008-01-17
TouchTime=01:00

[Languages]
Name: "fr"; MessagesFile: "compiler:Languages\French.isl"

; emplacement des fichiers à inclure dans setup.exe :
[Files]
Source: "Cadet.exe"; DestDir: "{app}" ; Flags:  touch
Source: "codegenere.xslt"; DestDir: "{app}"; Flags:  touch
Source: "default.css"; DestDir: "{app}" ; Flags:  touch
Source: "lisezmoi.txt"; DestDir: "{app}"; Flags:  touch isreadme
Source: "Cadet.chm"; DestDir: "{app}" ; Flags:  touch
Source: "presentation.html"; DestDir: "{app}" ; Flags:  touch
Source: "documentation.html"; DestDir: "{app}"  ; Flags:  touch
Source: "Exécutables\*"; DestDir: "{app}\Exécutable" ; Flags:  touch
Source: "Images\*"; DestDir: "{app}\Images"; Flags:  touch
Source: "Sources\*"; DestDir: "{app}\Sources"; Flags: recursesubdirs touch

[UninstallDelete]
Type: files; Name: "{app}\codeDASM.txt"
Type: files; Name: "{app}\codegenere.exec"
Type: files; Name: "{app}\codegenere.txt"
Type: files; Name: "{app}\codegenere.xml"
Type: files; Name: "{app}\Cadet.ini"

[Icons]
; icones menu demarrer
Name: "{group}\Cadet"; Filename: "{app}\Cadet.exe"
Name: "{group}\Aide d'Cadet"; Filename: "{app}\Cadet.chm"
Name: "{group}\Documentation d'Cadet"; Filename: "{app}\documentation.html"
Name: "{group}\Lisez-moi"; Filename: "{app}\lisezmoi.txt"
Name: "{group}\Désinstaller Cadet"; Filename: "{app}\unins000.exe"
Name: "{group}\Sources d'Cadet"; Filename: "{app}\Sources"
; icones bureau
Name: "{commondesktop}\Cadet"; Filename: "{app}\Cadet.exe"
Name: "{commondesktop}\Sources d'Cadet"; Filename: "{app}\Sources"
;--FIN

