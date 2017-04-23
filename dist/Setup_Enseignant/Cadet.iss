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
;Fichier d'installation version enseignant
;==========================================================================

[Setup]
AppName=Cadet
AppVerName=Cadet Version 1.0
DefaultDirName={pf}\Cadet
DefaultGroupName=Cadet
UninstallDisplayIcon={app}\Cadet.exe
Compression=lzma
SolidCompression=yes
;chemin des fichier source
SourceDir=C:\Cadet\
; chemin de creation de setup.exe :
OutputDir=C:\
; mise à jour des date heure des fichiers (time = version)
TouchDate=2008-01-17
TouchTime=01:00

[Languages]
Name: "fr"; MessagesFile: "compiler:Languages\French.isl"

; emplacement des fichiers à inclure dans setup.exe :
[Files]
Source: "Executable\lisezmoi.txt"; DestDir: "{app}"; Flags:  touch isreadme
Source: "Executable\*"; DestDir: "{app}" ; Flags: recursesubdirs touch
Source: "*"; DestDir: "{app}\Sources"; Flags: recursesubdirs touch

[UninstallDelete]
Type: files; Name: "{app}\Executable\codeDASM.txt"
Type: files; Name: "{app}\Executable\codegenere.exec"
Type: files; Name: "{app}\Executable\codegenere.txt"
Type: files; Name: "{app}\Executable\codegenere.xml"
Type: files; Name: "{app}\Executable\Cadet.ini"

[Icons]
Name: "{group}\Cadet"; Filename: "{app}\Cadet.exe"
Name: "{group}\Aide"; Filename: "{app}\Cadet.chm"
Name: "{group}\Documentation"; Filename: "{app}\documentation.html"
Name: "{group}\Lisez-moi"; Filename: "{app}\lisezmoi.txt"
Name: "{group}\Désinstaller Cadet"; Filename: "{app}\unins000.exe"
Name: "{commondesktop}\Cadet"; Filename: "{app}\Cadet.exe"
Name: "{group}\Sources d'Cadet"; Filename: "{app}\Sources"
Name: "{commondesktop}\Sources d'Cadet"; Filename: "{app}\Sources"


