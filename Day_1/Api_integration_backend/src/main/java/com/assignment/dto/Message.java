package com.assignment.dto;


public class Message {
	
	private String role;
	private String massage;
	
	public Message(String role, String massage) {
		super();
		this.role = role;
		this.massage = massage;
	}
	
	public Message() {
		// TODO Auto-generated constructor stub
	}

	public String getRole() {
		return role;
	}

	public void setRole(String role) {
		this.role = role;
	}

	public String getMassage() {
		return massage;
	}

	public void setMassage(String massage) {
		this.massage = massage;
	}
	
	

}
