En resumen, Unas clases sirven como decoradoras de otra clase, todas deben implementar una misma interfaz

Provee un mecanismo para colocar un nuevo comportamiento en tiempo de ejecución

El objeto no sabe que esta siendo decorado

Tiene instancia de la clase original y desciende de ella

No se necesita una superclase con todas las características

Cada decoración es independiente de las demás

Podemos colocarlas según las necesitemos

No depende de la herencia para adicionar nuevos comportamientos

Se recomienda usar clases abstractas, el autor prefiere interfaces

- Componentes
    
    Componente: La clase original que será decorada
    
    IComponent: Interfaz que identifica los objetos que pueden ser decorados
    
    Operación: La operación que puede ser reemplazada
    
    Decorador: La clase que implementa a IComponent y adiciona estado o comportamiento
    

![Untitled](https://prod-files-secure.s3.us-west-2.amazonaws.com/ebed6a9d-7949-4002-81fd-e511808fdedb/7d25576e-8d53-44f5-8cc9-910ca9d2193b/Untitled.png)

![Untitled](https://prod-files-secure.s3.us-west-2.amazonaws.com/ebed6a9d-7949-4002-81fd-e511808fdedb/93af29e2-4977-422f-bc46-eb19a5855f88/Untitled.png)

- Cuando usarlo?
    
    Cuando necesitamos agregar comportamientos pero la herencia puedo complicar las cosas
    
    Agregar comportamientos en tiempo de ejecución
    
    Cambiar objetos de la clase sin modificar otros objetos de la misma clase
    
    Evitar hacer mas clases hijas
    
- Desventajas
    
    El decorador y el objeto que envuelve no son del mismo tipo
    
    Podemos acabar con muchos objetos pequeños en memoria
    
    Cuando se tienen muchos decoradores se puede complicar el mantenimiento
