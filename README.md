# INF320-Appsmoviles
## Proyecto 1: App para generacion de colores

### Desafíos encontrados durante el desarrollo
- Adentrarse inicialmente en un nuevo framework para el desarrollo de aplicaciones.
- Reconocer la estructura del proyecto e identificar que archivos editar.
- Analizar y solucionar errores de compilación relacionados al binding (conexión) entre XAML y C#, como del namespace de la app.


### Impedimentos encontrados durante el desarrollo
- En esta primera instancia el mayor impedimento fue la instalacion de todos los prerrequisitos.
- En el caso de Linux habian pequeñas discrepancias con las instalaciones normales que entorpecieron el dejar todo andando.

### Recursos utilizados durante el desarrollo (documentación, bibliografía, uso de IA)
#### Documentacion
- [Documentación MAUI](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/contentpage?view=net-maui-10.0)
- [ColorNames Library Documentation](https://www.nuget.org/packages/ColorNamesSharp/#readme-body-tab)
- [Dotnet string formats](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)

#### Bibliografia
- [Instalacion con Linux](https://youtu.be/s-clGkUbk84?si=xRfXpYIc-Owraxqg)
- [Instalacion con Linux](https://www.youtube.com/watch?v=4D2vUYUIqFU)
- [Instalar Plantillas MAUI faltantes en Linux](https://stackoverflow.com/questions/75921435/net-maui-templates-not-in-visual-studio-2022-community)
- [Arreglar lentitud emulador Android en Linux](https://stackoverflow.com/questions/65254168/android-emulator-very-slow-on-ubuntu-20-04)
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet)

#### Uso de IA
- Se utilizó Claude como herramienta de asistencia para la elaboración del proyecto, usándose para: 
  - Encontrar las funciones de C# y librerías que sirvieran para elaborar el proyecto.
  - Diagnosticar errores de compilación ya mencionados

### Conclusiones
- Hay una complejidad no trivial al momento de configurar el entorno de desarrollo
- Como esta app era lo suficientemente básica, no se requirió de una estructura compleja.


## Proyecto 2: App para dividir la cuenta

### Desafíos encontrados durante el desarrollo
- Entender que es MVVM y entender como usar la biblioteca ComunnityToolkit.mvvm
- Implementar data binding entre la vista (XAML) y la lógica (CalculadoraViewModel.cs)

### Impedimentos encontrados durante el desarrollo
- En esta segunda instancia el mayor impedimento fue expandir nuestro conocimiento del uso del framework .NET MAUI como de sus librerías.

### Recursos utilizados durante el desarrollo (documentación, bibliografía, uso de IA)
#### Documentacion
- [Documentación MAUI](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/contentpage?view=net-maui-10.0)
- [Dotnet string formats](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings)
- [Community Toolkit](https://learn.microsoft.com/en-us/dotnet/architecture/maui/mvvm-community-toolkit-features)

#### Bibliografia
- [Instalacion con Linux](https://youtu.be/s-clGkUbk84?si=xRfXpYIc-Owraxqg)
- [Instalacion con Linux](https://www.youtube.com/watch?v=4D2vUYUIqFU)
- [Instalar Plantillas MAUI faltantes en Linux](https://stackoverflow.com/questions/75921435/net-maui-templates-not-in-visual-studio-2022-community)
- [Arreglar lentitud emulador Android en Linux](https://stackoverflow.com/questions/65254168/android-emulator-very-slow-on-ubuntu-20-04)
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet)
- [.NET MAUI crash course: MVVM, Databinding and Dependency Injection](https://www.youtube.com/watch?v=XmdBXuNPShs)

#### Uso de IA
- Se utilizó Claude como herramienta de asistencia para la elaboración del proyecto, usándose para: 
  - Encontrar las funciones de C# y librerías que sirvieran para elaborar el proyecto.
  - Entender como hacer data binding entre la lógica y la vista.

### Conclusiones
- Hay una complejidad no trivial al momento de configurar el entorno de desarrollo
- El uso de el patrón MVVM ayuda a reducir la dependencia del código
- La baja acoplación que se logra con este patrón es fundamental para aplicar pruebas unitarias
