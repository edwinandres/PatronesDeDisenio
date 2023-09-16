Sirve para desacoplar implementación de abstracción

Se usa cuando hay una nueva versión de software pero el cliente va a usar la anterior

El cliente indica con que versión va a trabajar

- VENTAJAS
    
    Interfaz del cliente permanece constante sin importar los cambios de la abstracción
    
    Evita compilar cliente, solo compilamos el bridge
    
    Esconde implementaciones del cliente
    
- COMPONENTES
    
    Abstracción : Interfaz que el cliente ve
    
    Operación: El metodo que invoca el cliente
    
    IBridge: Interfaz que muestra los comportamientos que pueden variar en la abstracción
    
    Implementación: Diferentes implementaciones de la abstracción
    
    OperaciónImp: Método que implementa la operación
    

![Untitled](https://prod-files-secure.s3.us-west-2.amazonaws.com/ebed6a9d-7949-4002-81fd-e511808fdedb/6719d661-55a5-46fe-a519-815e08c9b08b/Untitled.png)
