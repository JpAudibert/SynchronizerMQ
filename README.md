# SynchronizerMQ
The final work of DS college discipline

The goal is to implement a synchronizer for generic things,
such as database instructions, orders...

It's based on memory an in a normal flow, synchronizes in a queue, FIFO protocol.
But sometimes, you may notice that some problem happened with some instruction,
based on this situation, you can rollback the integration, update the instruction
and restart the batch integration.

Enjoy it!
