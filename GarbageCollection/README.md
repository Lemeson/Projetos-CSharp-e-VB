Para iniciar o programa abra o arquivo ".sln".
Programa demosntra o funcionamento do Garbage Collector, o qual trabalha nas instancias existentes na memória Heap.
O Front End é composto por um formulário que contém um botão. Ao clicar é inserida novas instancias (1000 intancias).
Por trás está rodando um timer que ao percorrer o tempo (de 0 até < 1000) roda uma nova instancia do metodo DEMO. A classe Demo contém um Constutor e um Destructor.
Quando o Destrucutor é executado ele libera os recursos da memória recuperando (reclaimed memory) a mesma que foi liberada.
E como a variavel Instances de DEMO é estática (shared em VB), é inicializada apenas uma vez sendo incrementada sempre que é chamado o contrutor da Classe.
