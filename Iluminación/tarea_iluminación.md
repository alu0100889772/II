Light mapping: Se utiliza para precalcular la iluminación de las superficies de una escena teniendo en cuenta las mallas, materiales, texturas y luces. Los resultados se guardan para ser usados cuando sea necesario.

Bump mapping: Se utiliza para simular bultos o arrugas en la superficie de un objeto sin alterar el modelo, la iluminación es la que hace que lo parezca. Para ello se modifican los vectores normales de las superficies.

Normal mapping: Es una implementación del Bump mapping, añade detalles a un modelo sin que el modelo necesita más polígonos. Se suele usar para mejorar la apariencia y detalles de un modelo con poco polígonos generando un Normal map desde un modelo con muchos polígonos.

Sky box: Es lo que envuelve una escena. Puede ser un cubo de seis texturas o una esfera.

Environment mapping: Es un tipo de iluminación basada en imágenes que se utiliza para aproximar la apariencia de una superficie reflectora gracias a una textura precomputada.

Iluminación global: Consiste en que para la iluminación de una escena no se utilice solo la iluminación que viene directamente de las fuentes de lus sino también aquella que rebota en los objetos de la escena.
