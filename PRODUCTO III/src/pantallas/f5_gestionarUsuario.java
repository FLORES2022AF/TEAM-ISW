package pantallas;

import conexion.Conexion;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author EQUIPO 1:
 *                - GERARDO DE JESUS MARTINEZ MATA
 *                - JORGE ALEJANDRO POSEROS RAMOS
 *                - BENJAMIN RODRIGUEZ VERASTEGUI
 *                - ALEKSANDRA ESTEFANIA SANCHEZ FLORES
 */
public class f5_gestionarUsuario extends javax.swing.JFrame {
 Conexion baseDatos = new Conexion().conectar();
 
    public f5_gestionarUsuario() {
        initComponents();
        setLocationRelativeTo(null);
        botonBusquedaUsuarioGU.setEnabled(false);
        botonDarDeAltaUsuario.setEnabled(false);
        botonBorrarUsuario.setEnabled(false);
        botonModificarUsuario.setEnabled(false);
    }
    public void validarBuscar(){
        if(valorBusqueda.getText().isEmpty()){
            botonBusquedaUsuarioGU.setEnabled(false);
        }else{
            botonBusquedaUsuarioGU.setEnabled(true);
        }
    }
    
    public void validarBorrar(){
        if(id_usuario.getText().isEmpty()){
            botonBorrarUsuario.setEnabled(false);
        }else{
            botonBorrarUsuario.setEnabled(true);
        }
    }
    
    public void validarModificar(){
        if(id_usuario.getText().isEmpty() || nombre.getText().isEmpty() ||
                paterno.getText().isEmpty() ||materno.getText().isEmpty() ||
                textusuario.getText().isEmpty() || tpass.getText().isEmpty()){
            botonModificarUsuario.setEnabled(false);
        }else{
            botonModificarUsuario.setEnabled(true);
        }
    }
    public void validarAlta(){
        if(id_usuario.getText().isEmpty() || nombre.getText().isEmpty() ||
                paterno.getText().isEmpty() ||materno.getText().isEmpty() ||
                textusuario.getText().isEmpty() || tpass.getText().isEmpty()){
            botonDarDeAltaUsuario.setEnabled(false);
        }else{
            botonDarDeAltaUsuario.setEnabled(true);
        }
    }
    
         int rol = f1_login.rol;

    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        contenedorFormGestionarUsuario = new javax.swing.JPanel();
        etiquetaBusquedaPor = new javax.swing.JLabel();
        etiquetaIdUsuario = new javax.swing.JLabel();
        etiquetaNombreUsuario = new javax.swing.JLabel();
        etiquetaApellidoPaternoUsuario = new javax.swing.JLabel();
        etiquetaApellidoMaternoUsuario = new javax.swing.JLabel();
        etiquetaUsuarioCorreoGU = new javax.swing.JLabel();
        etiquetaContraseñaGU = new javax.swing.JLabel();
        etiquetaTipoDeUsuarioGU = new javax.swing.JLabel();
        filtroDeBusqueda = new javax.swing.JComboBox<>();
        valorBusqueda = new javax.swing.JTextField();
        id_usuario = new javax.swing.JTextField();
        nombre = new javax.swing.JTextField();
        paterno = new javax.swing.JTextField();
        materno = new javax.swing.JTextField();
        textusuario = new javax.swing.JTextField();
        tpass = new javax.swing.JTextField();
        seleccionarTipoUsuarioOpcion1Dueno = new javax.swing.JRadioButton();
        seleccionarTipoUsuarioOpcion2Encargado = new javax.swing.JRadioButton();
        botonBusquedaUsuarioGU = new javax.swing.JButton();
        botonDarDeAltaUsuario = new javax.swing.JButton();
        botonModificarUsuario = new javax.swing.JButton();
        botonBorrarUsuario = new javax.swing.JButton();
        botonRegresarAMenu = new javax.swing.JButton();
        fondoGU = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("GESTIONAR USUARIO");

        contenedorFormGestionarUsuario.setBackground(new java.awt.Color(102, 204, 255));
        contenedorFormGestionarUsuario.setMinimumSize(new java.awt.Dimension(1000, 500));
        contenedorFormGestionarUsuario.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGestionarUsuario.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        etiquetaBusquedaPor.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaBusquedaPor.setText("BUSCAR POR:");
        contenedorFormGestionarUsuario.add(etiquetaBusquedaPor, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 150, 70, 20));

        etiquetaIdUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaIdUsuario.setText("Id Usuario:");
        contenedorFormGestionarUsuario.add(etiquetaIdUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 200, -1, -1));

        etiquetaNombreUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaNombreUsuario.setText("Nombre:");
        contenedorFormGestionarUsuario.add(etiquetaNombreUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 230, -1, -1));

        etiquetaApellidoPaternoUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaApellidoPaternoUsuario.setText("Apellido Paterno:");
        contenedorFormGestionarUsuario.add(etiquetaApellidoPaternoUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 260, -1, -1));

        etiquetaApellidoMaternoUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaApellidoMaternoUsuario.setText("Apellido Materno:");
        contenedorFormGestionarUsuario.add(etiquetaApellidoMaternoUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 290, -1, -1));

        etiquetaUsuarioCorreoGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaUsuarioCorreoGU.setText("Usuario:");
        contenedorFormGestionarUsuario.add(etiquetaUsuarioCorreoGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 320, -1, -1));

        etiquetaContraseñaGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaContraseñaGU.setText("Contraseña:");
        contenedorFormGestionarUsuario.add(etiquetaContraseñaGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 350, -1, -1));

        etiquetaTipoDeUsuarioGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        etiquetaTipoDeUsuarioGU.setText("Tipo De Usuario:");
        contenedorFormGestionarUsuario.add(etiquetaTipoDeUsuarioGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 320, -1, -1));

        filtroDeBusqueda.setBackground(new java.awt.Color(147, 175, 197));
        filtroDeBusqueda.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        filtroDeBusqueda.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "ID USUARIO", "USUARIO" }));
        filtroDeBusqueda.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                filtroDeBusquedaActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(filtroDeBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 150, 170, -1));

        valorBusqueda.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                valorBusquedaKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                valorBusquedaKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(valorBusqueda, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 150, 280, -1));

        id_usuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                id_usuarioActionPerformed(evt);
            }
        });
        id_usuario.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                id_usuarioKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                id_usuarioKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(id_usuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 190, 140, 30));

        nombre.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                nombreKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                nombreKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(nombre, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 220, 610, 30));

        paterno.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                paternoKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                paternoKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(paterno, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 250, 610, 30));

        materno.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                maternoKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                maternoKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(materno, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 280, 610, 30));

        textusuario.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                textusuarioKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                textusuarioKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(textusuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 310, 360, 30));

        tpass.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyReleased(java.awt.event.KeyEvent evt) {
                tpassKeyReleased(evt);
            }
            public void keyTyped(java.awt.event.KeyEvent evt) {
                tpassKeyTyped(evt);
            }
        });
        contenedorFormGestionarUsuario.add(tpass, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 340, 360, 30));

        seleccionarTipoUsuarioOpcion1Dueno.setText("Dueño");
        contenedorFormGestionarUsuario.add(seleccionarTipoUsuarioOpcion1Dueno, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 320, -1, -1));

        seleccionarTipoUsuarioOpcion2Encargado.setText("Encargado");
        contenedorFormGestionarUsuario.add(seleccionarTipoUsuarioOpcion2Encargado, new org.netbeans.lib.awtextra.AbsoluteConstraints(740, 320, -1, -1));

        botonBusquedaUsuarioGU.setBackground(new java.awt.Color(74, 96, 106));
        botonBusquedaUsuarioGU.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBusquedaUsuarioGU.setForeground(new java.awt.Color(255, 255, 255));
        botonBusquedaUsuarioGU.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/V)iconoBusquedaDeUsuario_GU_1.png"))); // NOI18N
        botonBusquedaUsuarioGU.setText("BUSCAR USUARIO");
        botonBusquedaUsuarioGU.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonBusquedaUsuarioGUActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonBusquedaUsuarioGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 130, 170, -1));

        botonDarDeAltaUsuario.setBackground(new java.awt.Color(74, 96, 106));
        botonDarDeAltaUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonDarDeAltaUsuario.setForeground(new java.awt.Color(255, 255, 255));
        botonDarDeAltaUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/W)iconoDarDeAltaUsuarioGestionarUsuario_2.png"))); // NOI18N
        botonDarDeAltaUsuario.setText("DAR DE ALTA USUARIO");
        botonDarDeAltaUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonDarDeAltaUsuarioActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonDarDeAltaUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 380, 190, 40));

        botonModificarUsuario.setBackground(new java.awt.Color(74, 96, 106));
        botonModificarUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonModificarUsuario.setForeground(new java.awt.Color(255, 255, 255));
        botonModificarUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/X)iconoModificarUsuarioGestionarUsuario_2.png"))); // NOI18N
        botonModificarUsuario.setText("MODIFICAR USUARIO");
        botonModificarUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonModificarUsuarioActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonModificarUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 380, 180, 40));

        botonBorrarUsuario.setBackground(new java.awt.Color(74, 96, 106));
        botonBorrarUsuario.setFont(new java.awt.Font("Cambria", 0, 12)); // NOI18N
        botonBorrarUsuario.setForeground(new java.awt.Color(255, 255, 255));
        botonBorrarUsuario.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/Y)iconoBorrarUsuarioGestionarUsuario_4.png"))); // NOI18N
        botonBorrarUsuario.setText("BORRAR USUARIO");
        botonBorrarUsuario.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonBorrarUsuarioActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonBorrarUsuario, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 380, 180, 40));

        botonRegresarAMenu.setBackground(new java.awt.Color(74, 96, 106));
        botonRegresarAMenu.setFont(new java.awt.Font("Cambria", 0, 18)); // NOI18N
        botonRegresarAMenu.setForeground(new java.awt.Color(255, 255, 255));
        botonRegresarAMenu.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/Z)iconoBotonRegresarAMenu_GU_5.png"))); // NOI18N
        botonRegresarAMenu.setText("REGRESAR A MENÚ");
        botonRegresarAMenu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                botonRegresarAMenuActionPerformed(evt);
            }
        });
        contenedorFormGestionarUsuario.add(botonRegresarAMenu, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 450, 220, 40));

        fondoGU.setIcon(new javax.swing.ImageIcon(getClass().getResource("/imagenes/6)fondoPantallaGestionarUsuario.jpeg"))); // NOI18N
        fondoGU.setVerticalAlignment(javax.swing.SwingConstants.TOP);
        fondoGU.setMaximumSize(new java.awt.Dimension(1000, 500));
        fondoGU.setMinimumSize(new java.awt.Dimension(1000, 500));
        fondoGU.setPreferredSize(new java.awt.Dimension(1000, 500));
        contenedorFormGestionarUsuario.add(fondoGU, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1000, 500));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarUsuario, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(contenedorFormGestionarUsuario, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void filtroDeBusquedaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_filtroDeBusquedaActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_filtroDeBusquedaActionPerformed

    private void id_usuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_id_usuarioActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_id_usuarioActionPerformed

    private void botonModificarUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonModificarUsuarioActionPerformed
        // TODO add your handling code here:
        
        int eleccion;
        eleccion = filtroDeBusqueda.getSelectedIndex();
        
        if(eleccion == 0){

            String id_u, nomb, pat, mat, usua, contra;
                id_u = valorBusqueda.getText();
                nomb = nombre.getText();
                pat = paterno.getText();
                mat = materno.getText();
                usua = textusuario.getText();
                contra = tpass.getText();
                int i = 0;

                if(seleccionarTipoUsuarioOpcion1Dueno.isSelected() && seleccionarTipoUsuarioOpcion2Encargado.isSelected()){

                    JOptionPane.showMessageDialog(null,"Seleccione solo una opcion de tipo de encargado",null, JOptionPane.INFORMATION_MESSAGE);
                }else if(seleccionarTipoUsuarioOpcion1Dueno.isSelected()){

                        i = 1;
                }else if(seleccionarTipoUsuarioOpcion2Encargado.isSelected()){
                        i = 2;
                }else{
                        JOptionPane.showMessageDialog(null,"Seleccione una opcion de tipo de encargado",null, JOptionPane.INFORMATION_MESSAGE);
                    }            


                if (valorBusqueda.getText().length() != 0 && nombre.getText().length() != 0 && paterno.getText().length() != 0 &&
                    materno.getText().length() != 0 && textusuario.getText().length() != 0 && tpass.getText().length() != 0 && i != 0){


                boolean sentencia;
                sentencia = baseDatos.ejecutar("UPDATE USUARIOS SET NOMBRE = '"+nomb+"', PATERNO = '"+pat+"', MATERNO = '"+mat +"', USUARIO = '"+usua+"', CLAVE = '"+contra+"', T_USUARIO = '"+i+"' WHERE ID_USUARIOS = "+id_u + "");
                
                
                
                JOptionPane.showMessageDialog(null,"El usuario esta modificado",null, JOptionPane.INFORMATION_MESSAGE);
            }else{
                JOptionPane.showMessageDialog(null,"Rellena todos los campos" ,null, JOptionPane.ERROR_MESSAGE);
            }
        }else if(eleccion == 1){
            String id_u, nomb, pat, mat, usua, contra;
        id_u = id_usuario.getText();
        nomb = nombre.getText();
        pat = paterno.getText();
        mat = materno.getText();
        usua = valorBusqueda.getText();
        contra = tpass.getText();
        int i = 0;
        
        if(seleccionarTipoUsuarioOpcion1Dueno.isSelected() && seleccionarTipoUsuarioOpcion2Encargado.isSelected()){
            
            JOptionPane.showMessageDialog(null,"Seleccione solo una opcion de tipo de encargado",null, JOptionPane.INFORMATION_MESSAGE);
        }else if(seleccionarTipoUsuarioOpcion1Dueno.isSelected()){
            
                i = 1;
        }else if(seleccionarTipoUsuarioOpcion2Encargado.isSelected()){
                i = 2;
        }else{
                JOptionPane.showMessageDialog(null,"Seleccione una opcion de tipo de encargado",null, JOptionPane.INFORMATION_MESSAGE);
            }            
        
            
        if (id_usuario.getText().length() != 0 && nombre.getText().length() != 0 && paterno.getText().length() != 0 &&
            materno.getText().length() != 0 && textusuario.getText().length() != 0 && tpass.getText().length() != 0 && i != 0){
        
          
        boolean sentencia;
        sentencia = baseDatos.ejecutar("UPDATE USUARIOS SET ID_USUARIOS = '"+id_u+"', "+"NOMBRE = '"+nomb+"', PATERNO = '"+pat+"', MATERNO = '"+mat +"', CLAVE = '"+contra+"', T_USUARIO = '"+i+"' WHERE USUARIO = '"+usua+"'");
        
        JOptionPane.showMessageDialog(null,"El usuario se modifico",null, JOptionPane.INFORMATION_MESSAGE);
        }else{
            JOptionPane.showMessageDialog(null,"Rellena todos los campos" ,null, JOptionPane.ERROR_MESSAGE);
        }
        }

        
    }//GEN-LAST:event_botonModificarUsuarioActionPerformed

    private void botonBorrarUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonBorrarUsuarioActionPerformed
        // TODO add your handling code here:
        int eleccion;
        eleccion = filtroDeBusqueda.getSelectedIndex();
        boolean sentencia = false;
        if(eleccion == 0){
        sentencia = baseDatos.ejecutar("DELETE FROM USUARIOS WHERE ID_USUARIOS = '" + valorBusqueda.getText() + "'");
        }else if(eleccion == 1){
            sentencia = baseDatos.ejecutar("DELETE FROM USUARIOS WHERE USUARIO = '" + valorBusqueda.getText() + "'");
            
        }
        JOptionPane.showMessageDialog(null,"Usuario esta esta borrado",null, JOptionPane.INFORMATION_MESSAGE);
    }//GEN-LAST:event_botonBorrarUsuarioActionPerformed

    private void botonRegresarAMenuActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonRegresarAMenuActionPerformed
if(rol == 1){
                    new f2_menuDueno().setVisible(true);
                   dispose();
                }else{
                    new f2_menuEncargado().setVisible(true);
                   dispose();
                }        
    }//GEN-LAST:event_botonRegresarAMenuActionPerformed

    private void botonDarDeAltaUsuarioActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonDarDeAltaUsuarioActionPerformed
        String id_u, nomb, pat, mat, usua, contra;
        id_u = id_usuario.getText();
        nomb = nombre.getText();
        pat = paterno.getText();
        mat = materno.getText();
        usua = textusuario.getText();
        contra = tpass.getText();
        int i = 0;
        
        if(seleccionarTipoUsuarioOpcion1Dueno.isSelected() && seleccionarTipoUsuarioOpcion2Encargado.isSelected()){
            
            JOptionPane.showMessageDialog(null,"Seleccione solo una opcion de tipo de encargado",null, JOptionPane.INFORMATION_MESSAGE);
        }else if(seleccionarTipoUsuarioOpcion1Dueno.isSelected()){
            
                i = 1;
        }else if(seleccionarTipoUsuarioOpcion2Encargado.isSelected()){
                i = 2;
        }else{
                JOptionPane.showMessageDialog(null,"Seleccione una opcion de tipo de encargado",null, JOptionPane.INFORMATION_MESSAGE);
            }            
        
            
        if (id_usuario.getText().length() != 0 && nombre.getText().length() != 0 && paterno.getText().length() != 0 &&
            materno.getText().length() != 0 && textusuario.getText().length() != 0 && tpass.getText().length() != 0 && i != 0){
        
          
        boolean sentencia;
        sentencia = baseDatos.ejecutar("INSERT INTO USUARIOS VALUES('"+id_u+"', '"+nomb+"', '"+pat+"','"+mat +"', '"+usua+"', '"+contra+"', '"+i+"')");
        JOptionPane.showMessageDialog(null,"Usuario esta dado de alta",null, JOptionPane.INFORMATION_MESSAGE);
        }else{
            JOptionPane.showMessageDialog(null,"Rellena todos los campos" ,null, JOptionPane.ERROR_MESSAGE);
        }
    }//GEN-LAST:event_botonDarDeAltaUsuarioActionPerformed

    private void botonBusquedaUsuarioGUActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_botonBusquedaUsuarioGUActionPerformed
        // TODO add your handling code here:
        int eleccion;
        eleccion = filtroDeBusqueda.getSelectedIndex();
        
        if(eleccion == 0){
            
            ResultSet resultado = baseDatos.consultar("SELECT * FROM USUARIOS WHERE ID_USUARIOS = '" + valorBusqueda.getText() + "'");
            try {
                while(resultado.next()){
                    id_usuario.setText(resultado.getString("ID_USUARIOS"));       
                    nombre.setText(resultado.getString("NOMBRE"));
                    paterno.setText(resultado.getString("PATERNO"));
                    materno.setText(resultado.getString("MATERNO"));
                    textusuario.setText(resultado.getString("USUARIO"));
                    tpass.setText(resultado.getString("CLAVE"));
                    
                    int  i = resultado.getInt("T_USUARIO");
                    
                    if(i == 1){
                        seleccionarTipoUsuarioOpcion1Dueno.setSelected(true);
                        seleccionarTipoUsuarioOpcion2Encargado.setSelected(false);
                    }else{
                        seleccionarTipoUsuarioOpcion1Dueno.setSelected(false);
                        seleccionarTipoUsuarioOpcion2Encargado.setSelected(true);
                    }
                    
                }
            } catch (SQLException ex) {
                Logger.getLogger(f5_gestionarUsuario.class.getName()).log(Level.SEVERE, null, ex);
            }
        }else if(eleccion == 1){
                
            ResultSet resultado = baseDatos.consultar("SELECT * FROM USUARIOS WHERE USUARIO = '" + valorBusqueda.getText() + "'");
            try {
                while(resultado.next()){
                    id_usuario.setText(resultado.getString("ID_USUARIOS"));       
                    nombre.setText(resultado.getString("NOMBRE"));
                    paterno.setText(resultado.getString("PATERNO"));
                    materno.setText(resultado.getString("MATERNO"));
                    textusuario.setText(resultado.getString("USUARIO"));
                    tpass.setText(resultado.getString("CLAVE"));
                    
                    int  i = resultado.getInt("T_USUARIO");
                    
                    if(i == 1){
                        seleccionarTipoUsuarioOpcion1Dueno.setSelected(true);
                        seleccionarTipoUsuarioOpcion2Encargado.setSelected(false);
                    }else{
                        seleccionarTipoUsuarioOpcion1Dueno.setSelected(false);
                        seleccionarTipoUsuarioOpcion2Encargado.setSelected(true);
                    }
                    
                }
            } catch (SQLException ex) {
                Logger.getLogger(f5_gestionarUsuario.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
          
    }//GEN-LAST:event_botonBusquedaUsuarioGUActionPerformed

    private void valorBusquedaKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_valorBusquedaKeyReleased
            validarBuscar();       // TODO add your handling code here:
    }//GEN-LAST:event_valorBusquedaKeyReleased

    private void valorBusquedaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_valorBusquedaKeyTyped
 if(valorBusqueda.getText().length() >= 10)
    {
        evt.consume();
    }       // TODO add your handling code here:
    }//GEN-LAST:event_valorBusquedaKeyTyped

    private void id_usuarioKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_id_usuarioKeyReleased
validarModificar();  
validarBorrar();
validarAlta();// TODO add your handling code here:
    }//GEN-LAST:event_id_usuarioKeyReleased

    private void nombreKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_nombreKeyReleased
validarModificar(); 
validarAlta();// TODO add your handling code here:
    }//GEN-LAST:event_nombreKeyReleased

    private void paternoKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_paternoKeyReleased
validarModificar(); 
validarAlta();// TODO add your handling code here:
    }//GEN-LAST:event_paternoKeyReleased

    private void maternoKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_maternoKeyReleased
validarModificar(); 
validarAlta();// TODO add your handling code here:
    }//GEN-LAST:event_maternoKeyReleased

    private void textusuarioKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_textusuarioKeyReleased
validarModificar();
validarAlta();// TODO add your handling code here:
    }//GEN-LAST:event_textusuarioKeyReleased

    private void tpassKeyReleased(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_tpassKeyReleased
validarModificar();  
validarAlta();// TODO add your handling code here:
    }//GEN-LAST:event_tpassKeyReleased

    private void id_usuarioKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_id_usuarioKeyTyped
if(id_usuario.getText().length() >= 4)
    {
        evt.consume();
    }        // TODO add your handling code here:
    }//GEN-LAST:event_id_usuarioKeyTyped

    private void nombreKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_nombreKeyTyped
     if(nombre.getText().length() >= 20)
    {
        evt.consume();
    }   // TODO add your handling code here:
    }//GEN-LAST:event_nombreKeyTyped

    private void paternoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_paternoKeyTyped
          if(paterno.getText().length() >= 20)
    {
        evt.consume();
    }  // TODO add your handling code here:
    }//GEN-LAST:event_paternoKeyTyped

    private void maternoKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_maternoKeyTyped
         if(materno.getText().length() >= 20)
    {
        evt.consume();
    }// TODO add your handling code here:
    }//GEN-LAST:event_maternoKeyTyped

    private void textusuarioKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_textusuarioKeyTyped
 
         if(textusuario.getText().length() >= 15)
    {
        evt.consume();
    }
         // TODO add your handling code here:
    }//GEN-LAST:event_textusuarioKeyTyped

    private void tpassKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_tpassKeyTyped

 if(tpass.getText().length() >= 15)
    {
        evt.consume();
    }        // TODO add your handling code here:
    }//GEN-LAST:event_tpassKeyTyped
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(f5_gestionarUsuario.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new f5_gestionarUsuario().setVisible(true);
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton botonBorrarUsuario;
    private javax.swing.JButton botonBusquedaUsuarioGU;
    private javax.swing.JButton botonDarDeAltaUsuario;
    private javax.swing.JButton botonModificarUsuario;
    private javax.swing.JButton botonRegresarAMenu;
    private javax.swing.JPanel contenedorFormGestionarUsuario;
    private javax.swing.JLabel etiquetaApellidoMaternoUsuario;
    private javax.swing.JLabel etiquetaApellidoPaternoUsuario;
    private javax.swing.JLabel etiquetaBusquedaPor;
    private javax.swing.JLabel etiquetaContraseñaGU;
    private javax.swing.JLabel etiquetaIdUsuario;
    private javax.swing.JLabel etiquetaNombreUsuario;
    private javax.swing.JLabel etiquetaTipoDeUsuarioGU;
    private javax.swing.JLabel etiquetaUsuarioCorreoGU;
    private javax.swing.JComboBox<String> filtroDeBusqueda;
    private javax.swing.JLabel fondoGU;
    private javax.swing.JTextField id_usuario;
    private javax.swing.JTextField materno;
    private javax.swing.JTextField nombre;
    private javax.swing.JTextField paterno;
    private javax.swing.JRadioButton seleccionarTipoUsuarioOpcion1Dueno;
    private javax.swing.JRadioButton seleccionarTipoUsuarioOpcion2Encargado;
    private javax.swing.JTextField textusuario;
    private javax.swing.JTextField tpass;
    private javax.swing.JTextField valorBusqueda;
    // End of variables declaration//GEN-END:variables
}
