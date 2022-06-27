package cola.numerico;
/**
 * Aplicación de una Cola Circular.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 *
 * @version 1.00 15/08/11
 */
class AppCola {
	public static void main(String[] args) {
		Cola laCola = new Cola(5); // La cola Contiene 5 elementos

		laCola.inserta(10); // adiciona 4 elementos
		laCola.inserta(20);
		laCola.inserta(30);
		laCola.inserta(40);

		laCola.elimina(); // elimina 3 elementos
		laCola.elimina(); // (10, 20, 30)
		laCola.elimina();

		laCola.inserta(50); // adiciona 4 elementos mas
		laCola.inserta(60); // (al principio del arreglo)
		laCola.inserta(70);
		laCola.inserta(80);

		while (!laCola.estaVacia()) { // elimina y despliega todos los elementos
			long valor = laCola.elimina(); // (40, 50, 60, 70, 80)
			System.out.print(valor);
			System.out.print(" ");
		}
		System.out.println("");
	} // fin main()
} // fin de la clase AppCola
