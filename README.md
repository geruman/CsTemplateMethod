# Template method
Es un patr�n de comportamiento. [Link de la descripci�n](https://sourcemaking.com/design_patterns/template_method)

El patr�n template method permite delegar la implementaci�n de uno o m�s m�todos en subclases de un padre abstracto, dicho padre define un m�todo que establecera el orden en que se llamen a los dem�s m�todos y las subclases son las encargadas de definir la implementaci�n de cada uno.

## Diagrama de clases
![UML](template_method.jpg)

## SOLID

* Single responsability

Template method ayuda a tener clases con una sola responsabilidad permitiendo crear subclases que definan comportamiento en los m�todos abstractos heredados para tener variedad de algoritmos distintos que atiendan un fin com�n.

* Open/Closed principle

Este principio no es ayudado por el template method ya que solo se puede escalar verticalmente entre los m�todos abstractos heredados, si hace falta crear nuevos m�todos o cambiar la relaci�n entre ellos habra que modificar el funcionamiento de la clase abstracta padre.

* Liskov substitution

El principio de Liskov juega bien con template method ya que todas las implementaciones de la clase abstracta deben ser intercambiables entre s�.

* Interface segregation

Nos permite tener varias implementaciones de los algoritmos separadas en funcionalidad sin recurrir a una superclase llena de if/elses

* Dependency inversion

Este principio tambi�n juega bien con template method ya que siempre podemos referirnos a los algoritmos a traves de la superclase abstracta.