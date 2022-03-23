fun main(args: Array<String>) {

    var handPlayer1 = Hand()
    var handPlayer2 = Hand()

    handPlayer1.rollDice()
    handPlayer2.rollDice()

    handPlayer1.printDice()
    handPlayer2.printDice()

    val yambPlayer1 = Yamb(handPlayer1.lockedDice)
    val yambPlayer2 = Yamb(handPlayer2.lockedDice)

    println("Player 1 Results:")
    yambPlayer1.results()

    println("Player 2 Results:")
    yambPlayer2.results()
}