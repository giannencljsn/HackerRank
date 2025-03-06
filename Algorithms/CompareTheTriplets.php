<?php

/*
 * Complete the 'compareTriplets' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER_ARRAY a
 *  2. INTEGER_ARRAY b
 */

function compareTriplets($a, $b) {
   $alice_score =0;
   $bob_score = 0;
   $result = array();
   
   //iterate through both array and compare
       for($j=0; $j <count($b); $j++){
           $num1 = $a[$j];
          $num2 = $b[$j];
            echo "\n"."Alice number:".$num1;
            echo "\n"."Bob number:".$num2;
            
         if($num1 > $num2){
              $alice_score++;
          }else if ($num1 < $num2){
              $bob_score++;
          }
       }
      
    echo "\n"."Alice Score:".$alice_score;
    echo "\n"."Bob Score:".$bob_score;
    array_push($result, $alice_score, $bob_score);
    return $result;
}

$fptr = fopen(getenv("OUTPUT_PATH"), "w");

$a_temp = rtrim(fgets(STDIN));

$a = array_map('intval', preg_split('/ /', $a_temp, -1, PREG_SPLIT_NO_EMPTY));

$b_temp = rtrim(fgets(STDIN));

$b = array_map('intval', preg_split('/ /', $b_temp, -1, PREG_SPLIT_NO_EMPTY));

$result = compareTriplets($a, $b);

fwrite($fptr, implode(" ", $result) . "\n");

fclose($fptr);
