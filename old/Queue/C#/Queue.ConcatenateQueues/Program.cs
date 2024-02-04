using C_.MovieTheater;

var queue1 = new ExtendedQueue<int>();
queue1.Insert(1);
queue1.Insert(3);
queue1.Insert(5);
queue1.Insert(7);
queue1.Insert(9);
queue1.Insert(11);

var queue2 = new ExtendedQueue<int>();
queue2.Insert(2);
queue2.Insert(4);
queue2.Insert(6);
queue2.Insert(8);
queue2.Insert(10);
queue2.Insert(12);

var queue3 = queue1.ConcatenateWith(queue2);

queue3.Show(item => item);