class Yamb(val dice: List<Die>) {
    fun results() {
        var counter = 0
        var result = 0
        var checkStraight = true
        var valuesArray = mutableListOf<Int>()

        for (die in dice) {
            val noOfRepatedDice = dice.count { it.value == die.value }
            if (noOfRepatedDice > counter)
                counter = noOfRepatedDice
            result += die.value
            valuesArray.add(die.value)
        }
        valuesArray.sort()
        for (i in 1..6) {
            if (i != valuesArray.get(i - 1))
                checkStraight = false
        }
        println("Score: " + result)
        when (counter) {
            4, 5 -> println("POKER!")
            6 -> println("YAMB!")
        }
        if (checkStraight)
            println("STRAIGHT!")
    }
}