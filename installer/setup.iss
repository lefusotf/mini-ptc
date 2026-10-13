; Instalador de PTC (Inno Setup 6)
; Instala el programa + SQL Server Express (si no esta) + crea la base de datos.
; Ver LEEME.md para los pasos.

; ---- EDITAR ESTOS VALORES ------------------------------------------------
#define AppName    "PTC"
#define AppVersion "1.0"
#define AppExe     "PTC.exe"                  ; nombre del .exe que genera Visual Studio
#define BuildDir   "..\TuProyecto\bin\Release" ; carpeta con el .exe compilado en Release
                                               ; (.NET 6+: usar la carpeta "publish", ver LEEME.md)
#define DbName     "PTC"                      ; nombre de la base en SSMS
; --------------------------------------------------------------------------

#define Instance   "SQLEXPRESS"

[Setup]
AppId={{FCF397B1-8F41-49BA-A66A-357906F16F30}
AppName={#AppName}
AppVersion={#AppVersion}
DefaultDirName={autopf}\{#AppName}
DefaultGroupName={#AppName}
OutputDir=salida
OutputBaseFilename=Setup_{#AppName}
Compression=lzma2
SolidCompression=yes
PrivilegesRequired=admin
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
WizardStyle=modern
UninstallDisplayIcon={app}\{#AppExe}

[Languages]
Name: "spanish"; MessagesFile: "compiler:Languages\Spanish.isl"

[Tasks]
Name: "desktopicon"; Description: "Crear un acceso directo en el escritorio"; Flags: unchecked

[Files]
; El programa compilado (sin los .pdb)
Source: "{#BuildDir}\*"; DestDir: "{app}"; Excludes: "*.pdb"; Flags: ignoreversion recursesubdirs createallsubdirs
; Scripts de la base de datos
Source: "crear_base.ps1"; DestDir: "{app}\db"; Flags: ignoreversion
Source: "base.sql";       DestDir: "{app}\db"; Flags: ignoreversion
; Instalador de SQL Server Express: va dentro del Setup y solo se extrae si hace falta
Source: "prereqs\SQLEXPR_x64_ENU.exe"; DestDir: "{tmp}"; Flags: dontcopy

[Icons]
Name: "{group}\{#AppName}"; Filename: "{app}\{#AppExe}"
Name: "{group}\Desinstalar {#AppName}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#AppName}"; Filename: "{app}\{#AppExe}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#AppExe}"; Description: "Abrir {#AppName}"; Flags: nowait postinstall skipifsilent

[Code]
function SqlInstalado: Boolean;
var
  Valor: String;
begin
  Result := RegQueryStringValue(HKLM64,
    'SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL',
    '{#Instance}', Valor);
end;

procedure CurStepChanged(CurStep: TSetupStep);
var
  Codigo: Integer;
  Params: String;
begin
  if CurStep <> ssPostInstall then Exit;

  { 1) SQL Server Express, solo si la instancia no existe }
  if not SqlInstalado then
  begin
    WizardForm.StatusLabel.Caption :=
      'Instalando SQL Server Express (puede tardar varios minutos)...';
    ExtractTemporaryFile('SQLEXPR_x64_ENU.exe');
    { El usuario que instala queda como administrador de SQL (autenticacion de Windows) }
    Params := '/Q /ACTION=Install /FEATURES=SQLENGINE /INSTANCENAME={#Instance} ' +
              '/IACCEPTSQLSERVERLICENSETERMS /UPDATEENABLED=0 ' +
              '/SQLSYSADMINACCOUNTS="' + ExpandConstant('{computername}\{username}') + '"';
    if (not Exec(ExpandConstant('{tmp}\SQLEXPR_x64_ENU.exe'), Params, '',
                 SW_HIDE, ewWaitUntilTerminated, Codigo))
       or ((Codigo <> 0) and (Codigo <> 3010)) then
    begin
      MsgBox('No se pudo instalar SQL Server Express (codigo ' + IntToStr(Codigo) + ').' + #13#10 +
             'El programa quedo copiado pero la base de datos NO fue creada.',
             mbError, MB_OK);
      Exit;
    end;
  end;

  { 2) Crear la base y cargar los datos (si la base ya existe no se toca) }
  WizardForm.StatusLabel.Caption := 'Preparando la base de datos...';
  Params := '-NoProfile -ExecutionPolicy Bypass -File "' +
            ExpandConstant('{app}\db\crear_base.ps1') + '" ' +
            '-Instancia ".\{#Instance}" -Base "{#DbName}" ' +
            '-Script "' + ExpandConstant('{app}\db\base.sql') + '"';
  if (not Exec('powershell.exe', Params, '', SW_HIDE, ewWaitUntilTerminated, Codigo))
     or (Codigo <> 0) then
    MsgBox('No se pudo preparar la base de datos.' + #13#10 +
           'Detalle en: ' + ExpandConstant('{%TEMP}\instalacion_base.log'),
           mbError, MB_OK);
end;
