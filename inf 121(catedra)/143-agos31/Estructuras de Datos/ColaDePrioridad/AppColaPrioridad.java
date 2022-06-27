package colaprioridad;
/**
 * Aplicación de una Cola de Prioridad.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 21/08/11
 * 
 */
public class AppColaPrioridad {
	public static void main(String[] args) {
		ColaPrioridad laCP = new ColaPrioridad(5);
		laCP.inserta(30);
		laCP.inserta(50);
		laCP.inserta(10);
		laCP.inserta(40);
		laCP.inserta(20);

		while (!laCP.estaVacia()) {
			long elemento = laCP.elimina();
			System.out.print(elemento + " "); // 10, 20, 30, 40, 50
		} // fin while
		System.out.println("");
	} // fin main()
	// -------------------------------------------------------------
} // fin de la clase AppColaPrioridad
