# nombre del instalador. ponemos el nombre que queramos
outfile "instaladorAvituallamientos.exe"

# define el directorio donde se va a instalar. Cogemos la ruta del Escritorio (donde saldria el icono de cualkier app)
installDir $DESKTOP\InstalacionAppAvituallamiento

# Necesario para borrar el acceso directo en Windows (user o admin)
RequestExecutionLevel admin

# Pantallas que hay que mostrar del instalador

Page directory
Page instfiles


#Cambiar el idioma
!include "MUI.nsh"
!insertmacro MUI_LANGUAGE "Spanish"


# Seccion por defecto
section
 
	# Definimos la ruta en la que vamos a escribir el archivo
	setOutPath $INSTDIR
	
		 
	# Escribimos el archivo en la ruta de salida 
	
	File Avituallamientos.exe
		
	
	
	# creamos el desinstalador y su nombre
	writeUninstaller $INSTDIR\uninstaller.exe	
	
	
	 # Creamos un acceso directo en menu de inicio($SMPRORAMS) apuntando al desinstalador ($INSTDIR\uninstall.exe)
    createShortCut "$SMPROGRAMS\AccDirUninstallAvituallamiento.lnk" "$INSTDIR\uninstaller.exe"
	
	 #Añadimos información para que salga en el menú de agregar/quitar programas de Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamiento" \
                 "DisplayName" "Avituallamientos"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamiento" \
                 "Publisher" "Avituallamientos ORG"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamiento" \
                 "UninstallString" "$\"$INSTDIR\uninstaller.exe$\""
				 
	
sectionEnd

# Creamos una seccion para definir el comportamiento del desinstalador
# siempre se va a llamar uninstall
section "Uninstall"
	 
	# Borramos primero el desinstalador
	delete $INSTDIR\uninstaller.exe
	 
	# borramos el archivo que habiamos instalado
	delete $INSTDIR\Avituallamientos.exe
	
		
	
	   # borramos el acceso directo del menu de inicio
    delete "$SMPROGRAMS\AccDirUninstallAvituallamiento.lnk"
	
	#borramos el instalador
	delete $INSTDIR\instaladorAvituallamientos.exe
 
 #Borramos la entrada del registro
	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\Avituallamiento"
	
	#Siempre lo ponemos el ultimo. borra directorios vacios (carpetas), por loq tiene q estar el ultimo	
	
	RmDir "$INSTDIR"
sectionEnd
