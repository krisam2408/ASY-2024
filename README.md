<h1>ET ASY5131 Año 2024</h1> 
<p>Grupo 3</p>
<p>Integrantes:</p>
<ul>
<li>Bornhardt, Christoph</li>
<li>Serre. Michelle</li>
<li>Torres, Nicolás</li>
</ul>

<p>Este repositorio contiene toda la evidencia del desarrollo del caso transversal y su documentación.</p>

<h3><b>* IMPORTANTE: ESTE PROYECTO REQUIERE QUE SE CLONE UN SEGUNDO REPOSITORIO PARA FUNCIONAR</b></h3>
<p>Segundo repositorio: <a href="https://github.com/krisam2408/Utilities">Utilities</a></p>

<h2>Lenguajes</h2>
<ul>
<li>.NET Core 8 - C#</li>
<li>SASS</li>
<li>JavaScript</li>
<li>HTML - Razor (CSHTML)</li>
<li>TSQL</li>
</ul>
<br>
<h2>Tecnologías</h2>
<ul>
<li>Docker</li>
<li>SQL Server</li>
<li>Visual Studio Community 2022</li>
<li>Git</li>
</ul>
<br>
<h2>DB</h2>
<p>La Base de Datos se construyó utilizando un acercamiento Code-First. Lo que significa que se estableció la arquitectura de clases dentro de la capa modelo del proyecto y luego fue automáticamente traducida a un modelo de entidades desde el código al motor de base de datos.</p>
<br>
<h2>Arquitectura</h2>
<p>Se utilizó una arquitectura MVC clásica, así como está recomendado en el template de Microsoft para páginas Razor (no confundir con Blazor)</p>
<br>
<h2>Frameworks</h2>
<ul>
<li>.NET Core 8</li>
<li>ASP.Net</li>
<li>Entity Framework</li>
<li>Bootstrap</li>
<li>Utilities (Utilities es un repositorio de utilidades generado por el integrante Bornhardt, C.)</li>
<li>xUnit</li>
</ul>
<br>
<h2>Librerías Extra</h2>
<ul>
<li>Newtonsoft</li>
<li>TransbankSDK</li>
</ul>
<br>
<h2>Pasos de Implementación</h2>
<p>Estos pasos consideran los siguientes requerimientos:</p>
<ul>
<li>Docker instalado (se utilizó la instalación WSL)</li>
<li>SQL Server virtualizado en contenedor Docker</li>
<li>Visual Studio Community 2022 (Professional y Enterprise deberían funcionar también)</li>
<li>SDK NET Core 8 instalado</li>
</ul>
<h3>Clonar repositorios</h3>
<ul>
<li>Clone repositorio principal (este) al directorio de su preferencia</li>
<li>Clone repositorio Utilities al mismo directorio</li>
</ul>
<h3>Virtualización de Base de Datos en Docker</h3>
<ul>
<li>Abra el programa que prefiera para configurar Docker (Terminal, CMD, Visual Studio Code, etc...)</li>
<li>Navegue al directorio del repositorio principal (debería encontrar los archivos 'docker-compose.yml' y '.env')</li>
<li>Ejecute el comando 'docker-compose up -d'</li>
</ul>
<h3>Creación de Base de Datos</h3>
<ul>
<li>Seleccione el programa para administrar SQL Server de su preferencia (SQL Server Management Studio, Azure Data Studio, ...)</li>
<li>Conéctese al motor de SQL Server (Usuario: sa, Contraseña: UnaClave2024)</li>
<li>Ejecute archivo SQL 'db_setup.sql' que se encuentra en directorio raíz del repositorio principal para crear la base de datos</li>
<li>Abrir Visual Studio 2022</li>
<li>Abrir solución desde '~/Ferramas/Ferramas.sln'</li>
<li>Abrir 'Package Manager Console' desde la opción de menú 'Tools -> Nuget Package Manager -> Package Manager Console'</li>
<li>Ejecutar desde consola el comando 'update-database'</li>
</ul>
<h3>Despliegue de Plataforma</h3>
<ul>
<li>Asegúrese de que el proyecto 'Ferramas' aparezca como proyecto de inicio e inicie depuración</li>
</ul>
<h3>Despliegue de Pruebas Unitarias</h3>
<ul>
<li>Abra el explorador de pruebas desde la opción de menú 'View -> Test Explorer'</li>
<li>Dentro de la ventana, haga clic en el botón de reproducción</li>
</ul>