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
    

![Bridge](https://github.com/edwinandres/PatronesDisenio/blob/master/PatronBridge/bridge.png)
