package bicola;

/**
 * Aplicación de una Bi Cola.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 21/08/11
 * 
 */
class AppBiCola {
	public static void main(String[] args) {
		BiCola laCola = new BiCola(3); // Cola Contiene 5 elementos

		laCola.adicionaIzq(10); // adiciona 4 elementos
		System.out.println(laCola);
		laCola.adicionaIzq(20);
		System.out.println(laCola);
		laCola.adicionaIzq(30);
		System.out.println(laCola);
		laCola.adicionaIzq(40);
		System.out.println(laCola);
		
		/*laCola.adicionarIzq(10); // adiciona 4 elementos
		System.out.println(laCola);
		laCola.adicionarIzq(20);
		System.out.println(laCola);
		laCola.adicionarIzq(30);
		System.out.println(laCola);
		laCola.adicionarIzq(40);
		System.out.println(laCola);
		*/

		System.out.println(laCola.eliminaIzq());
		System.out.println(laCola.eliminaIzq());
		System.out.println(laCola.eliminaIzq());
		System.out.println(laCola.eliminaIzq());
		
		System.out.println("");
	} // fin main()
} // fin de la clase AppBiCola
