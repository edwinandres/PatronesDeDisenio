Da soporte a objetos que controlan la creación y el acceso a otros objetos

Es un punto intermedio entre el cliente y otros objetos

Un ejemplo: mecanismo de registro y login para un sitio web. No se tiene acceso a determinados objetos hasta que el usuario no este registrado y logueado

Si un calculo lleva mucho tiempo en realizarse, se puede usar el proxy para mostrar resultados intermedios.

ADO .NET hace un proxy para conectar a base de datos

- COMPONENTES
    
    ISujeto: Interfaz común de los proxys y sujetos. Permite usarlos e intercambiarlos cuando sea necesario
    
    Sujeto: La clase representada por el proxy, se usará cuando el proxy lo permita
    
    Proxy: La clase que crea, controla y da acceso al sujeto
    
    Petición : Una operación en el sujeto que es enviada vía proxy
    

![Proxy](https://github.com/edwinandres/PatronesDisenio/blob/master/PatronProxy/proxy.png)

- TIPOS DE PROXY
    
    Virtual: Da la creación de un objeto a otro
    
    Autenticación: Verifica que los permisos de acceso sean los adecuados
    
    Remoto: Codifica las peticiones y las envía por la red
    
    Smart: Adiciona o modifica las peticiones antes de enviarlas
