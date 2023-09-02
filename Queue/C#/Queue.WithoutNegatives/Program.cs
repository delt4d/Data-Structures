using C_.MovieTheater;

var queue = new ExtendedQueue();

queue.Insert(1);
queue.Insert(-3);
queue.Insert(23);
queue.Insert(15);
queue.Insert(100);
queue.Insert(-12);
queue.Insert(532);
queue.Insert(2);
queue.Insert(-42);
queue.Insert(-1);
queue.Insert(0);
queue.Insert(45);
queue.Insert(23);
queue.Insert(-24);
queue.Insert(0);
queue.Insert(-100);
queue.Insert(8);
queue.Insert(-9);

queue.Show(item => item);
queue.RemoveAllNegatives();
queue.Show(item => item);