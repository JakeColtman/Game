# N Dimensional turn based Engine

##Purpose

The purpose of this engine is two fold.  I want something that I can easily prototype turn based and board games in, with a particular focus on increasing dimensionality (e.g 3 or 4d draughts).  I also want to use this to build a game that layers different dimensional spaces over the same world.

##How it works

To accomodate my goal of multiple spaces layered over each other, I have avoided any particular space being definitional.  Instead the core of the engine are "Points".  Each point has an id and is a unique possible position that an entity can be in.  Points do not exist in any particular set of dimensions but instead contain references to other points in certain directions

Layered on top of the points are representations of the points which do have dimensionality.  A representation of a set of points is essentially a mapping from a coodinate system into the points.  The engine supports converters which can be used to translate between coordinate system.  I.e. they identify that a coordinate in space 1 refers to the same point as coordinate in space 2.  This decoupling of coordinate systems and the underlying points allows very fluid movements between the two.  Indeed, new spaces can be added at run time.

To meet the easy prototyping of games I have everywhere sacrificed performance for flexibility and ease of game design.  My engine is not designed to be a production engine for big games, but to allow playing around with concepts.

The core design decision in this setup is to base the entire engine around messaging.  All major actions in the engine are messages which can be subscribed to by any number of rules or logical triggers.  This allows the game designer to focus as much as possible on just expressing the rules of the game.

