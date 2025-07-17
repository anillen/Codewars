function logicalCalc(array, op) {
	let result = array[0]

	for (i = 1; i < array.length; i++) {
		switch (op) {
			case "AND":
				result = array[i] && result
				break
			case "OR":
				result = array[i] || result
				break
			case "XOR":
				result = array[i] !== result
				break
		}
		console.log(array[i])
	}

	return result
}
