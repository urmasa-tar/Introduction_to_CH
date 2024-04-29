using message;
using System;
using static message.str_message;
using static message.str_int_concat;
using static message.concat_multiple;

class Program
{
    public static void Main(string[] args)
    {
        /* 1) 
        str_message mess_concat = new str_message();

        mess_concat.concat();

        str_int_concat with_int = new str_int_concat();

        with_int.concat();
        */

        concat_multiple with_mult = new concat_multiple();

        with_mult.multiple_read();

    }


}