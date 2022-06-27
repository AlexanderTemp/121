package pila.numerico;
/**
 * Aplicación de una pila.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 15/08/11
 */
class AppPila {
	public static void main(String[] args) {
		Pila laPila = new Pila(5); // nueva pila
		laPila.inserta(20); // inserta elementos en la pila
		laPila.inserta(40);
		laPila.inserta(60);
		laPila.inserta(80);
		laPila.inserta(100);

		while (!laPila.estaVacia()) { // elimina elementos de la pila hasta que esté vacia
			long valor = laPila.elimina();
			System.out.print(valor); // despliega elemento
			System.out.print(" ");
		} // fin while
		System.out.println("");
	} // fin main()
} // fin clase AppPila