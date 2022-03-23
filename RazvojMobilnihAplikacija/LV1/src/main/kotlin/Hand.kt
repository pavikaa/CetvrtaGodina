class Hand {
    var dice = mutableListOf<Die>()
    var lockedDice = mutableListOf<Die>()

    fun rollDice() {

        for (i in 0 until 3) {

            dice.clear()

            if (lockedDice.size == 6)
                break

            for (j in 0 until 6 - lockedDice.size) {
                dice.add(Die((1..6).random()))
            }

            println("Dice rolled! The results are: ")
            for (die in dice) {
                println(die.value)
            }

            println(
                "Enter Y if you would like to lock any of the dice, \n" +
                        "enter K to keep all the dice, if you want to reroll enter any other key."
            );

            val check = readLine()!![0].uppercaseChar()

            if (check.equals('Y')) {
                lockDice()
            } else if (check.equals('K')) {
                addRemaining()
            }

            if (i == 2) {
                addRemaining()
            }
        }
    }

    fun lockDice() {
        for (die in dice) {
            println("Enter Y if you would like to lock the following die: " + die.value + "?")
            val check = readLine()!![0].uppercaseChar();
            if (check.equals('Y')) {
                lockedDice.add(die);
            }
        }
    }

    fun printDice() {
        println("Resulting dice are:")
        for (dice in lockedDice)
            println(dice.value)
    }

    fun addRemaining() {
        for (die in dice)
            lockedDice.add(die)
    }
}