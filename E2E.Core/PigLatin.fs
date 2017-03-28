namespace E2E.Core

open System

module PigLatin =
    let ToPigLatin (str: string) =
        let isVowel (ch: char) =
            let c = Char.ToUpper(ch)
            c = 'A' || c = 'E' || c = 'I' || c = 'O' || c = 'U'

        let firstChar = str.[0]

        if isVowel firstChar then
            str + "way"
        else
            str.[1..str.Length-1] + string(firstChar) + "ay"